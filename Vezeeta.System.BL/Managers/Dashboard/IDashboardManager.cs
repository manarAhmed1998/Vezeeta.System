using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.BL.DTOs.Doctors;

namespace Vezeeta.System.BL.Managers.Dashboard
{
    public interface IDashboardManager
    {
        int GetNumberOfDoctors();
        int GetNumberOfPatients();
        List<GetDoctorDTO> GetDoctors();
    }
}
