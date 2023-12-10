using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.BL.DTOs.Admin;
using Vezeeta.System.DAL;

namespace Vezeeta.System.BL.Services.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public LoginService(UserManager<ApplicationUser> userManager,
                              IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }
        public async Task<TokenDTO> Login(LoginDTO credentials)
        {
            var user = await _userManager.FindByEmailAsync(credentials.Email);
            if (user == null)
            {
                return null;
            }
            bool isAuthenticated = await _userManager.CheckPasswordAsync(user, credentials.Password);
            if (!isAuthenticated)
            {
                await _userManager.AccessFailedAsync(user);
                return null;
            }
            var userClaims = await _userManager.GetClaimsAsync(user);

            //fetching the sectkey from the config (generating the key)
            var secretKey = _configuration["SecretKey"];

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
    }
}
