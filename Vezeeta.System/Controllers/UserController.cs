using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Vezeeta.System.APIs.DTOs;
using Vezeeta.System.BL;
using Vezeeta.System.BL.Managers.Admin;
using Vezeeta.System.BL.Managers.DTOs;
using Vezeeta.System.DAL;

namespace Vezeeta.System.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IAdminManager _adminManager;
        public UserController(IConfiguration configuration,
            UserManager<ApplicationUser> userManager,
            IAdminManager adminManager
            )
        {
            _configuration = configuration;
            _userManager = userManager;
            _adminManager = adminManager;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<TokenDTO>> LoginAsync(LoginDTO credentials)
        {
            var user=await _userManager.FindByNameAsync(credentials.Email);

            if (user == null) return BadRequest("user not found");
            if (await _userManager.IsLockedOutAsync(user)) return BadRequest("try again");

            bool isAuthenticated=await _userManager.CheckPasswordAsync(user, credentials.Password);
            if (!isAuthenticated)
            {
                await _userManager.AccessFailedAsync(user);
                return Unauthorized("wrong password");
            }
            //generating token

            var userClaims=await _userManager.GetClaimsAsync(user);

            //fetching the sectkey from the config (generating the key)
            var secretKey = _configuration.GetValue<string>("SecretKey");

            //convertion
            var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKey);
            var key = new SymmetricSecurityKey(secretKeyInBytes);
            //determing how to generating hashing result
            var methodUsedInGenertaingToken = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var exp = DateTime.Now.AddMinutes(20);

            //define the token using another library to complete the hashing algorithim
            var jwt = new JwtSecurityToken(
                claims: userClaims,
                notBefore: DateTime.Now,
                expires: exp,
                signingCredentials: methodUsedInGenertaingToken
                );
            //creating the token
            var tokenHandler = new JwtSecurityTokenHandler();
            string tokenString = tokenHandler.WriteToken(jwt);

            return new TokenDTO
            {
                Token = tokenString,
                ExpiryDate = exp
            };
        }

        [HttpPost]
        [Route("AddDoctor")]
        //all user manager functions should be async
        public async Task<ActionResult<string>> RegisterAsync([FromBody]RegisterDTO credentials)
        {
            var result = await _adminManager.AddDoctor(credentials);
            return Ok(result);
        }
    }
}
