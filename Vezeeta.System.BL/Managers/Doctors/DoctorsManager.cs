using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.BL.Managers.DTOs;
using Vezeeta.System.DAL;

namespace Vezeeta.System.BL;

public class DoctorsManager : IDoctorsManager
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IConfiguration _configuration;

    public DoctorsManager(UserManager<ApplicationUser> userManager,
                          IConfiguration configuration)
    {
        _userManager = userManager;
        _configuration = configuration;
    }

}