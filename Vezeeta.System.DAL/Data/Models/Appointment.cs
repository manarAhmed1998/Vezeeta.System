using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class Appointment 
{ 
    public Guid Id { get; set; }
    //composite key configured in onModelCreating
    public Guid DoctorId { get; set; }
    public Day Day { get; set; }
    public Doctor Doctor { get; set; } = null!;
    public ICollection<Time> Times = new HashSet<Time>();
}
