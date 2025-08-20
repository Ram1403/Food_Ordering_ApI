using System;
using System.Collections.Generic;
using System.Linq;
using Food_Ordering_ApI.Data;
using Food_Ordering_ApI.Models;
using Microsoft.EntityFrameworkCore;
namespace Food_Ordering_ApI.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Food_AppDbContext _context;
        private static readonly Random _random = new Random();
        public CustomerRepository(Food_AppDbContext context)
        {
            _context = context;
        }
        public List<MenuItem> GetAllMenu()
        {
            return _context.MenuItems.ToList();
        }
        public Order PlaceOrder(PlaceOrderRequest request)
        {
            
            var customer = _context.Users
                                   .Include(u => u.UserRole)
                                   .FirstOrDefault(u => u.UserId == request.CustomerId);
          
            if (customer == null )
                throw new Exception("Invalid customer");


            
            var menuItems = _context.MenuItems
                                    .Where(m => request.Items.Select(i => i.MenuItemId).Contains(m.MenuItemId))
                                    .ToList();

            if (menuItems.Count != request.Items.Count)
                throw new Exception("One or more menu items not found");

          
            decimal subTotal = 0;
            var orderItems = new List<OrderItem>();

            foreach (var itemReq in request.Items)
            {
                var menuItem = menuItems.First(m => m.MenuItemId == itemReq.MenuItemId);

                decimal itemTotal = menuItem.Price * itemReq.Quantity;
                subTotal += itemTotal;

                orderItems.Add(new OrderItem
                {
                    MenuItemId = menuItem.MenuItemId,
                    Quantity = itemReq.Quantity,
                    UnitPrice = menuItem.Price   
                });
            }

            
            var discount = _context.Discounts.FirstOrDefault(d => subTotal >= d.Threshold);
            decimal discountApplied = discount != null ? discount.FlatDiscount : 0;
            decimal finalTotal = subTotal - discountApplied;

           
            var deliveryPartners = _context.DeliveryPartners.ToList();
            if (!deliveryPartners.Any())
                throw new Exception("No delivery partners available");

            var assignedPartner = deliveryPartners[_random.Next(deliveryPartners.Count)];

            
            var order = new Order
            {
                CustomerId = customer.UserId,
                OrderDate = DateTime.Now,
                SubTotal = subTotal,
                DiscountApplied = discountApplied,
                FinalTotal = finalTotal,
                PaymentMode = request.PaymentMode,
                DeliveryPartnerId = assignedPartner.DeliveryPartnerId,
                Items = orderItems
            };

            
            _context.Orders.Add(order);
            _context.SaveChanges();

            return order;
        }
    }
}
