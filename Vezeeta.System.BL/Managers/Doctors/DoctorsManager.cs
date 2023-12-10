using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.BL.DTOs.Doctors;
using Vezeeta.System.DAL;

namespace Vezeeta.System.BL;

public class DoctorsManager : IDoctorsManager
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IConfiguration _configuration;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDoctorsRepo _doctorsRepo;

    public DoctorsManager(UserManager<ApplicationUser> userManager,
                          IConfiguration configuration,
                          IUnitOfWork unitOfWork,
                          IDoctorsRepo doctorsRepo)
    {
        _userManager = userManager;
        _configuration = configuration;
        _unitOfWork = unitOfWork;
        _doctorsRepo = doctorsRepo;
    }
    public bool AddSetting(Guid Id, AddSettingDTO settings)
    {
        foreach (var dayDto in settings.Days)
        {
            var appointmentEntity = new Appointment
            {
                Id = Guid.NewGuid(),
                DoctorId = Id, // Set DoctorId as needed
                Day = (Day)dayDto.Day
            };

            var times = MapDtoTimesToEntityTimes(dayDto.TimeSlots, appointmentEntity.Id, Id);
            _unitOfWork.TimesRepo.AddRange(times);
            _unitOfWork.AppointmentsRepo.Add(appointmentEntity);
        }
        _unitOfWork.Save();
        return true;
    }

    //public IEnumerable<DoctorWithSettingsReadDTO> GetDoctorsWithSettings()
    //{
    //    var doctorsFromDb = _doctorsRepo.GetAllDoctorsWithSettings();
    //    return null;
    //}

    private List<Time> MapDtoTimesToEntityTimes(List<TimeSlotDTO> timeSlotsDto, Guid appointmentId, Guid doctorId)
    {
        var times = new List<Time>();

        foreach (var timeSlotDto in timeSlotsDto)
        {
            var timeEntity = new Time
            {
                TimeId = Guid.NewGuid(),
                AppointmentId = appointmentId,
                TimeInHours = timeSlotDto.StartTime,
                DoctorId = doctorId
            };

            times.Add(timeEntity);
        }

        return times;
    }
}