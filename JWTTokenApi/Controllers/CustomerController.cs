using JWTTokenApi.Model;
using JWTTokenApi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokenApi.Controllers
{   
  
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //GetAll Customers
        [HttpGet("GetCustomer")]
        public IActionResult getAllCustomer()
        {
            IEnumerable<Customer> customers = CustomerRepository.customers;
            return Ok(customers);
        }
    }
}
