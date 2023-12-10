using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.BL.DTOs.Doctors;

namespace Vezeeta.System.BL;

public interface IDoctorsManager
{
     bool AddSetting(Guid Id, AddSettingDTO settings);
    //public IEnumerable<DoctorWithSettingsReadDTO> GetDoctorsWithSettings();

}
