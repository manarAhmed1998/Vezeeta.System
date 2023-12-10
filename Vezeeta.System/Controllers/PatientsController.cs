using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vezeeta.System.BL;
using Vezeeta.System.BL.DTOs.Admin;
using Vezeeta.System.BL.DTOs.Doctors;
using Vezeeta.System.BL.DTOs.Patients;
using Vezeeta.System.BL.Services.LoginService;

namespace Vezeeta.System.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IPatientsManager _patientsManager;
        private readonly IDoctorsManager _doctorsManager;

        public PatientsController(ILoginService loginService,
            IPatientsManager patientsManager,
            IDoctorsManager doctorsManager)
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

        //[HttpGet("GetDoctorsWithSettings")]
        //public ActionResult<List<DoctorWithSettingsReadDTO>>GetAllDoctors()
        //{
        //    return _doctorsManager.GetDoctorsWithSettings().ToList();
        //}
    }
}
