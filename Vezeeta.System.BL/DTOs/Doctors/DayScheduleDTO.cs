using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.DAL;

namespace Vezeeta.System.BL.DTOs.Doctors
{
    public class DayScheduleDTO
    {
        public Day Day { get; set; }
        public List<TimeSlotDTO> TimeSlots { get; set; }
    }
}
