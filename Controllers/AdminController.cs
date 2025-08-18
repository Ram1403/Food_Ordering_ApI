using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Food_Ordering_ApI.Models;
using Food_Ordering_ApI.Services;
using Microsoft.AspNetCore.Authorization;
namespace Food_Ordering_ApI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        //admin mange user here
        [HttpPost("AddUser")]
        [Authorize(Roles = nameof(Role.ADMIN))]
        public IActionResult AddUser([FromBody] User user)
        {
            var addedUser = _adminService.AddUser(user);
            return Ok(addedUser);
        }
        [HttpGet("GetAllUser")]
        [Authorize(Roles = nameof(Role.ADMIN))]
        public IActionResult GetAllUser()
        {
            var users = _adminService.GetAllUser();
            return Ok(users);
        }
        [HttpDelete("DeleteUser/{id}")]
        [Authorize(Roles = nameof(Role.ADMIN))]
        public IActionResult DeleteUser(int id)
        {
            var deletedUser = _adminService.DeleteUser(id);
            return Ok(deletedUser);
        }

        //admin manage menu item here

        [HttpPost("AddMenuItem")]
        [Authorize(Roles = nameof(Role.ADMIN))]
        public IActionResult AddMenuItem([FromBody] MenuItem menuItem)
        {
            var addedItem = _adminService.AddMenuItem(menuItem);
            return Ok(addedItem);
        }
        [HttpPut("UpdateMenuItem")]
        [Authorize(Roles = nameof(Role.ADMIN))]
        public IActionResult UpdateMenuItem([FromBody] MenuItem menuItem)
        {
            var updatedItem = _adminService.UpdateMenuItem(menuItem);
            return Ok(updatedItem);
        }
        [HttpDelete("DeleteMenuItem/{id}")]
        [Authorize(Roles = nameof(Role.ADMIN))]
        public IActionResult DeleteMenuItem(int id)
        {
            var deletedItem = _adminService.DeleteMenuItem(id);
            return Ok(deletedItem);
        }
        [HttpGet("GetAllMenuItems")]
        [Authorize(Roles = nameof(Role.ADMIN))]
        public IActionResult GetAllMenuItems()
        {
            var items = _adminService.GetAllMenuItems();
            return Ok(items);
        }

        //admin manage discounts here

        [HttpPost("AddDiscount")]
        [Authorize(Roles = nameof(Role.ADMIN))]
        public IActionResult AddDiscount([FromBody] Discount discount)
        {
            var addedDiscount = _adminService.AddDiscount(discount);
            return Ok(addedDiscount);
        }

        //Admin manage delivery partners here
        [HttpPost("AddDeliveryPartner")]
        [Authorize(Roles = nameof(Role.ADMIN))]
        public IActionResult AddDeliveryPartner([FromBody] DeliveryPartner deliveryPartner)
        {
            var addedDeliveryPartner = _adminService.AddDeliveryPartner(deliveryPartner);
            return Ok(addedDeliveryPartner);
        }

        [HttpPut("UpdateDeliveryPartner")]
        [Authorize(Roles = nameof(Role.ADMIN))]
        public IActionResult UpdateDeliveryPartner([FromBody] DeliveryPartner deliveryPartner)
        {
            var updatedDeliveryPartner = _adminService.UpdateDeliveryPartner(deliveryPartner);
            return Ok(updatedDeliveryPartner);
        }
    }
}
