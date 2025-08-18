using Food_Ordering_ApI.Repositories;
using Food_Ordering_ApI.Models;

namespace Food_Ordering_ApI.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public User AddUser(User user)
        {
            return _adminRepository.AddUser(user);
        }
        public List<User> GetAllUser()
        {
            return _adminRepository.GetAllUser();
        }
        public User DeleteUser(int userId)
        {
            return _adminRepository.DeleteUser(userId);
        }
        public MenuItem AddMenuItem(MenuItem menuItem)
        {
            return _adminRepository.AddMenuItem(menuItem);
        }
        public MenuItem UpdateMenuItem(MenuItem menuItem)
        {
            return _adminRepository.UpdateMenuItem(menuItem);
        }
        public MenuItem DeleteMenuItem(int menuItemId)
        {
            return _adminRepository.DeleteMenuItem(menuItemId);
        }
        public List<MenuItem> GetAllMenuItems()
        {
            return _adminRepository.GetAllMenuItems();
        }
        public Discount AddDiscount(Discount discount)
        {
            return _adminRepository.AddDiscount(discount);
        }
        public Discount UpdateDiscount(Discount discount)
        {
            return _adminRepository.UpdateDiscount(discount);
        }
        public DeliveryPartner AddDeliveryPartner(DeliveryPartner deliveryPartner)
        {
            return _adminRepository.AddDeliveryPartner(deliveryPartner);
        }
        public DeliveryPartner UpdateDeliveryPartner(DeliveryPartner deliveryPartner)
        {
            return _adminRepository.UpdateDeliveryPartner(deliveryPartner);
        }
    }
}
