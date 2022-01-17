using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;
using JWTTokenApi.Repository;
using JWTTokenApi.JWT.IJwt;

namespace JWTTokenApi.JWT
{
    public class JWTTokenManager : IJWTTokenManager
    {
        private readonly IConfiguration _configuration;
        public JWTTokenManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        //Authenticate and return a token if authentication is successful
        public string Authenticate(string username, string password)
        {
            if(!User.Data.Any(u=> u.Key == username && u.Value == password ))
                return null;

            var key = _configuration.GetValue<string>("JwtConfig:key");
            var keyBytes = Encoding.ASCII.GetBytes(key);

            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier,username)
                }),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);

        }
    }
}
