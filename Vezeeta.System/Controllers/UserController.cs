using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Vezeeta.System.APIs.DTOs;
using Vezeeta.System.BL;
using Vezeeta.System.BL.DTOs.Admin;
using Vezeeta.System.BL.DTOs.Doctors;
using Vezeeta.System.BL.Managers.Admin;
using Vezeeta.System.BL.Managers.Dashboard;
using Vezeeta.System.BL.Services.LoginService;
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
        private readonly ILoginService _loginService;
        private readonly IDashboardManager _dashboardManager;
        public UserController(IConfiguration configuration,
            UserManager<ApplicationUser> userManager,
            IAdminManager adminManager,
            ILoginService loginService,
            IDashboardManager dashboardManager
            )
        {
            _configuration = configuration;
            _userManager = userManager;
            _adminManager = adminManager;
            _loginService = loginService;
            _dashboardManager = dashboardManager;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<TokenDTO>> LoginAsync(LoginDTO credentials)
        {
            var result = await _loginService.Login(credentials);
            if (result is null)
                return Unauthorized("Username or password isn't correct");
            return Ok(result);
        }

        [HttpPost]
        [Route("AddDoctor")]
        [Authorize (Policy = "Admin")]
        //all user manager functions should be async
        public async Task<ActionResult<string>> RegisterAsync([FromBody]RegisterDTO credentials)
        {
            var result = await _adminManager.AddDoctor(credentials);
            return Ok(result);
        }
        [HttpGet]
        [Route("GetAllDoctors")]
        [Authorize(Policy = "Admin")]
        public  ActionResult<List<GetDoctorDTO>> GetAllDoctors()
        {
            var result = _dashboardManager.GetDoctors();
            return Ok(result);
        }
        [HttpGet]
        [Route("Dashboard/NumberOfDoctors")]
        [Authorize(Policy = "Admin")]
        public ActionResult<int> GetDoctorsNumber()
        {
            var numberOfDoctors = _dashboardManager.GetNumberOfDoctors();
            return Ok(numberOfDoctors);
        }
        [HttpGet]
        [Route("Dashboard/NumberOfPatients")]
        [Authorize(Policy = "Admin")]
        public ActionResult<int> GetPatientsNumber()
        {
            var numberOfPatients = _dashboardManager.GetNumberOfPatients();
            return Ok(numberOfPatients);
        }
    }
}
