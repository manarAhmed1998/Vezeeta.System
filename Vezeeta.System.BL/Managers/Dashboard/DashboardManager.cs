using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.BL.DTOs.Doctors;
using Vezeeta.System.DAL;

namespace Vezeeta.System.BL.Managers.Dashboard
{
    public class DashboardManager : IDashboardManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public DashboardManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<GetDoctorDTO> GetDoctors()
        {
            var doctorsFromDB = _unitOfWork.DoctorsRepo.GetAll().Select
                (doctor => new GetDoctorDTO
                {
                    Name = doctor.Name,
                    Email = doctor.Email,
                    Img = doctor.Img,
                    Phones = doctor.Phone
                });
            return doctorsFromDB.ToList();
        }

        public int GetNumberOfDoctors()
        {
            return _unitOfWork.DoctorsRepo.Count();
        }
        public int GetNumberOfPatients()
        {
            return _unitOfWork.PatientsRepo.Count();
        }
    }
}
