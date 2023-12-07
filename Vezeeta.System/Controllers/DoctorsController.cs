using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vezeeta.System.BL;
using Vezeeta.System.BL.Managers.DTOs;
using Vezeeta.System.BL.Managers.LoginService;

namespace Vezeeta.System.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorsManager _manager;
        private readonly ILoginService _loginService;

        public DoctorsController(IDoctorsManager manager,
            ILoginService loginService)
        {
            _manager = manager;
            _loginService = loginService;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<TokenDTO>>LoginAsync(LoginDTO credentials)
        {
            var result = await _loginService.Login(credentials);
            if (result is null)
                return Unauthorized("Username or password isn't correct");
            return Ok(result);
        }
    }
}
