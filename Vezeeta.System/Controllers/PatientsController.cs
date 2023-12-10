using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vezeeta.System.BL;
using Vezeeta.System.BL.Managers.DTOs;
using Vezeeta.System.BL.Managers.LoginService;

namespace Vezeeta.System.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IPatientsManager _patientsManager;

        public PatientsController(ILoginService loginService, IPatientsManager patientsManager)
        {
            _loginService = loginService;
            _patientsManager = patientsManager;
        }
        [HttpPost("AddPatient")]
        public async Task<bool> RegisterAsync(AddPatientDTO credentials)
        {
            var result = await _patientsManager.AddPatient(credentials);
            return result;
        }
        [HttpPost("Login")]
        public async Task<ActionResult<TokenDTO>> LoginAsync(LoginDTO credentials)
        {
            var result = await _loginService.Login(credentials);
            if (result is null)
                return Unauthorized("Username or password isn't correct");
            return Ok(result);
        }

        [HttpGet("GetDoctors")]
        public ActionResult<List<DoctorReadDTO>>GetAllDoctors()
        {
            return _patientsManager.GetDoctors().ToList();
        }
    }
}
