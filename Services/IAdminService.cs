using Food_Ordering_ApI.Models;

namespace Food_Ordering_ApI.Services
{
    public interface IAdminService
    {

        User AddUser(User user);
        List<User> GetAllUser();
        User DeleteUser(int userId);
        MenuItem AddMenuItem(MenuItem menuItem);
        MenuItem UpdateMenuItem(MenuItem menuItem);
        MenuItem DeleteMenuItem(int menuItemId);
        List<MenuItem> GetAllMenuItems();

        Discount AddDiscount(Discount discount);
        Discount UpdateDiscount(Discount discount);

        DeliveryPartner AddDeliveryPartner(DeliveryPartner deliveryPartner);
        DeliveryPartner UpdateDeliveryPartner(DeliveryPartner deliveryPartner);
    }
}
