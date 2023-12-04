using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Vezeeta.System.APIs.DTOs.Authentication;

namespace Vezeeta.System.APIs.Controllers
{
    public class UserController : Controller
    {
        private readonly IConfiguration _configuration;
        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("login")]
        public ActionResult<string> Login(LoginDTO credentials)
        {
            if(credentials.UserName=="admin" && credentials.Password=="Test@123") 
            {
                var userClaims = new List<Claim>
                {
                    //default type claims
                    new Claim(ClaimTypes.NameIdentifier,credentials.UserName),
                    new Claim(ClaimTypes.Email,$"{credentials.UserName}@gmail.com"),
                    //custom type claim
                    new Claim("Subject","Admin")
                };
                //fetching the sectkey from the config (generating the key)
                var secretKey = _configuration.GetValue<string>("SecretKey");

                //convertion
                var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKey);
                var key = new SymmetricSecurityKey(secretKeyInBytes);
                //determing how to generating hashing result
                var methodUsedInGenertaingToken =new SigningCredentials(key,SecurityAlgorithms.HmacSha256Signature);

                //define the token using another library to complete the hashing algorithim
                var jwt = new JwtSecurityToken(
                    claims: userClaims,
                    notBefore:DateTime.Now,
                    expires:DateTime.Now.AddMinutes(20),
                    signingCredentials:methodUsedInGenertaingToken
                    );
                //creating the token
                var tokenHandler=new JwtSecurityTokenHandler();
                string tokenString=tokenHandler.WriteToken(jwt);

                return Ok( tokenString );

            }

            return Unauthorized("wrong credentials");
        }
    }
}
