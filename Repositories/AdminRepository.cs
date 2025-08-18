using Food_Ordering_ApI.Models;
using System.Collections.Generic;
using System.Linq;
using Food_Ordering_ApI.Data;
namespace Food_Ordering_ApI.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly Food_AppDbContext _context;
        public AdminRepository(Food_AppDbContext context)
        {
            _context = context;
        }

        public User AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
        public List<User> GetAllUser()
        {
            return _context.Users.ToList();
        }
        public User DeleteUser(int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
                return user;
            }
            throw new KeyNotFoundException("user not found for delete");
        }
        public MenuItem AddMenuItem(MenuItem menuItem)
        {
            _context.MenuItems.Add(menuItem);
            _context.SaveChanges();
            return menuItem;
        }
        public MenuItem UpdateMenuItem(MenuItem menuItem)
        {

            var existingItem = _context.MenuItems.FirstOrDefault(m => m.MenuItemId == menuItem.MenuItemId);
            if (existingItem != null)
            {
                existingItem.Name = menuItem.Name;
                existingItem.Price = menuItem.Price;
                _context.MenuItems.Update(existingItem);
                _context.SaveChanges();
                return existingItem;

            }
            throw new KeyNotFoundException("menue not found");
        }

        public MenuItem DeleteMenuItem(int menuItemId)
        {
            var Item = _context.MenuItems.FirstOrDefault(I => I.MenuItemId == menuItemId);
            if (Item != null)
            {
                _context.MenuItems.Remove(Item);
                _context.SaveChanges();
                return Item;
            }
            throw new KeyNotFoundException("menue not found for delete");
        }

        public List<MenuItem> GetAllMenuItems()
        {

            return _context.MenuItems.ToList();

        }

        public Discount AddDiscount(Discount discount)
        {
            _context.Discounts.Add(discount);
            _context.SaveChanges();
            return discount;
        }
        public Discount UpdateDiscount(Discount discount)
        {
            var existingDiscount = _context.Discounts.FirstOrDefault(d => d.DiscountId == discount.DiscountId);
            if (existingDiscount != null)
            {
                existingDiscount.Description = discount.Description;
                existingDiscount.Threshold = discount.Threshold;
                existingDiscount.FlatDiscount = discount.FlatDiscount;
                _context.Discounts.Update(existingDiscount);
                _context.SaveChanges();
                return existingDiscount;
            }
            throw new KeyNotFoundException("discount not found");
        }

        public DeliveryPartner AddDeliveryPartner(DeliveryPartner deliveryPartner)
        {
            _context.DeliveryPartners.Add(deliveryPartner);
            _context.SaveChanges();
            return deliveryPartner;
        }
        public DeliveryPartner UpdateDeliveryPartner(DeliveryPartner deliveryPartner)
        {
            var existingPartner = _context.DeliveryPartners.FirstOrDefault(dp => dp.DeliveryPartnerId == deliveryPartner.DeliveryPartnerId);
            if (existingPartner != null)
            {
                existingPartner.Name = deliveryPartner.Name;
                _context.DeliveryPartners.Update(existingPartner);
                _context.SaveChanges();
                return existingPartner;
            }
            throw new KeyNotFoundException("delivery partner not found");

        }


    }
}
