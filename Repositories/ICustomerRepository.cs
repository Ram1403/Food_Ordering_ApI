using Food_Ordering_ApI.Models;
using Food_Ordering_ApI.Data;
namespace Food_Ordering_ApI.Repositories
{
    public interface ICustomerRepository
    {
       List< MenuItem >GetAllMenu();
        Order PlaceOrder(PlaceOrderRequest request);


    }
}
