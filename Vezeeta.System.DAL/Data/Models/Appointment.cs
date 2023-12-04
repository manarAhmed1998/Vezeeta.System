using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class Appointment
{
    [Key]
    public int AppointmentDayNum { get; set; } //has to be 0-6
    [Key]
    public Guid DoctorId { get; set; }
    public Doctor Doctor { get; set; } = null!;
    public Day Day { get; set; }

    public ICollection<Time> Times = new HashSet<Time>();

}
