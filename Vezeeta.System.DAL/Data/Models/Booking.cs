using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class Booking
{
    public Guid BookingId { get; set; }
    public RequestStatus RequestStatus { get; set; }
    [ForeignKey(nameof(Time))]
    public Guid TimeId { get; set; }
    public Time Time { get; set; } = null!;
    [ForeignKey(nameof(Patient))]
    public Guid PatientId { get; set; }
    public Patient Patient { get; set; } = null!;
}
