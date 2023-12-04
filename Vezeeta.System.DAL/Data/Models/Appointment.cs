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
    public Guid DoctorId { get; set; }
    [Key]
    public Day Day { get; set; }
    public Doctor Doctor { get; set; } = null!;
    public ICollection<Time> Times = new HashSet<Time>();

}
