using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Food_Ordering_ApI.Models;
using Microsoft.AspNetCore.Authorization;   
using Food_Ordering_ApI.Services;

namespace Food_Ordering_ApI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("GetAllMenu")]
        [Authorize(Roles = nameof(Role.CUSTOMER))]
        public IActionResult GetAllMenu()
        {
            var menuItems = _customerService.GetAllMenu();
            return Ok(menuItems);
        }
        [HttpPost("PlaceOrder")]
        [Authorize(Roles = nameof(Role.CUSTOMER))]
        public IActionResult PlaceOrder([FromBody] PlaceOrderRequest request)
        {
            var order = _customerService.PlaceOrder(request);
            return Ok(order);
        }
    }
}
