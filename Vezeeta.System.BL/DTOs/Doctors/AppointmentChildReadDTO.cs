using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.BL.DTOs.Doctors;
using Vezeeta.System.DAL;

namespace Vezeeta.System.BL;

public class AppointmentChildReadDTO
{
    public Day Day { get; set; }
    public IEnumerable<TimeGrandChildReadDTO> Times {  get; set; }
        =new List<TimeGrandChildReadDTO>();
}
