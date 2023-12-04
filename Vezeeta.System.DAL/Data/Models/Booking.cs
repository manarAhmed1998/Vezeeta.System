using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class Booking
{
    public Guid BookingId { get; set; }
    public RequestStatus RequestStatus { get; set; }
    public Guid TimeId { get; set; }
    public Time Time { get; set; } = null!;
    public Guid PatientId { get; set; }
    public Patient Patient { get; set; } = null!;

}
