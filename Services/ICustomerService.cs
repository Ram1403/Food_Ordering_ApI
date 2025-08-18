using Food_Ordering_ApI.Models;

namespace Food_Ordering_ApI.Services
{
    public interface ICustomerService
    {
        List<MenuItem> GetAllMenu();
        Order PlaceOrder(PlaceOrderRequest request);
    }
}
