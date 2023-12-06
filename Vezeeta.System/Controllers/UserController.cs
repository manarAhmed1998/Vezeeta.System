using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Vezeeta.System.APIs.DTOs.Authentication;
using Vezeeta.System.APIs.DTOs.Token;
using Vezeeta.System.DAL;

namespace Vezeeta.System.APIs.Controllers
{
    public class UserController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;
        public UserController(IConfiguration configuration,UserManager<ApplicationUser> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }

        [HttpPost]
        [Route("staticLogin")]
        public ActionResult<string> StaticLogin(LoginDTO credentials)
        {
            if(credentials.UserName=="admin" && credentials.Password=="Test@123") 
            {
                var userClaims = new List<Claim>
                {
                    //default type claims
                    new Claim(ClaimTypes.NameIdentifier,credentials.UserName),
                    new Claim(ClaimTypes.Email,$"{credentials.UserName}@gmail.com")
                };
                //fetching the sectkey from the config (generating the key)
                var secretKey = _configuration.GetValue<string>("SecretKey");

                //convertion
                var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKey);
                var key = new SymmetricSecurityKey(secretKeyInBytes);
                //determing how to generating hashing result
                var methodUsedInGenertaingToken =new SigningCredentials(key,SecurityAlgorithms.HmacSha256Signature);

                var exp = DateTime.Now.AddMinutes(20);

                //define the token using another library to complete the hashing algorithim
                var jwt = new JwtSecurityToken(
                    claims: userClaims,
                    notBefore: DateTime.Now,
                    expires: exp,
                    signingCredentials: methodUsedInGenertaingToken
                    );
                //creating the token
                var tokenHandler=new JwtSecurityTokenHandler();
                string tokenString=tokenHandler.WriteToken(jwt);

                return Ok( tokenString );

            }

            return Unauthorized("wrong credentials");
        }


        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<TokenDTO>> LoginAsync(LoginDTO credentials)
        {
            var user=await _userManager.FindByNameAsync(credentials.UserName);

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
        [Route("register")]
        //all user manager functions should be async
        public async Task<ActionResult<string>> RegisterAsync(RegisterDTO credentials)
        {
            var newUser = new ApplicationUser
            {
                UserName = credentials.UserName,
                Email = credentials.Email,
                AccountType = AccountType.Patient
            };
            //password has to be hashed first then save to DB
            var creationResult = await _userManager.CreateAsync(newUser, credentials.Password);
            if(!creationResult.Succeeded)
            {
                return BadRequest(creationResult.Errors);
            }

            //assign some credentials for the user
            var userClaims = new List<Claim>
                {
                    //default type claims
                    new Claim(ClaimTypes.NameIdentifier,newUser.UserName),
                    new Claim(ClaimTypes.Email,newUser.Email)
                };
            await _userManager.AddClaimsAsync(newUser, userClaims);
            return Ok("done");
        }
    }
}
