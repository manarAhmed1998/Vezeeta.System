using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class Time
{
    public Guid TimeId { get; set; }
    [ForeignKey("DoctorId,Day")]
    public Guid DoctorId { get; set; }
    public Day Day { get; set; }
    public TimeOnly TimeInHours { get; set; }
    public Appointment Appointment { get; set; } = null!;
    public ICollection<Booking>? Bookings { get; set; }

}
