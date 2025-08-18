using Food_Ordering_ApI.Models;
using Food_Ordering_ApI.Repositories;
namespace Food_Ordering_ApI.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public List<MenuItem> GetAllMenu()
        {
            return _customerRepository.GetAllMenu();
        }
        public Order PlaceOrder(PlaceOrderRequest request)
        {
            return _customerRepository.PlaceOrder(request);
        }
    }
}
