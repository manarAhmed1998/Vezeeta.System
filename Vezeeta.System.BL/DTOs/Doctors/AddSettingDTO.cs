using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.DAL;

namespace Vezeeta.System.BL.DTOs.Doctors
{
    public class AddSettingDTO
    {
        public decimal Price { get; set; }
        public List<DayScheduleDTO> Days { get; set; }

    }
}
