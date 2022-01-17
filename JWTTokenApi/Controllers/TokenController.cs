using JWTTokenApi.JWT.IJwt;
using JWTTokenApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IJWTTokenManager _jWTTokenManager;
        public TokenController(IJWTTokenManager jWTTokenManager)
        {
            _jWTTokenManager = jWTTokenManager;
        }

        //Authentication
        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody] UserCredentials credential)
        {
          //token generated if authentication is successful
          var token =   _jWTTokenManager.Authenticate(credential.UserName, credential.Password);
          if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}
