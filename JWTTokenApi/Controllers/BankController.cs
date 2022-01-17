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
    public class BankController : ControllerBase
    {
        //Get All Banks
        [HttpGet("GetAllBanks")]
        public IActionResult getAllCustomer()
        {
            IEnumerable<Bank> banks = BankRepository.banks;
            return Ok(banks);
        }
    }
}
