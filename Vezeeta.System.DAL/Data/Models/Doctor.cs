using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.DAL;

namespace Vezeeta.System.DAL;
public class Doctor:User
{
    public ApplicationUser ApplicationUser { get; set; } = null!;
    //one-to-one optional key should be in the mandatory
    [ForeignKey("ApplicationUser")]
    public string ApplicationUserId { get; set; } = null!;
    [ForeignKey(nameof(Specialization))]
    public Guid SpecializationId { get; set; }
    public Specialization Specialization { get; set; } = null!;
    public ICollection<Appointment>? Appointments { get; set; }
    public Gender Gender { get; set; }  
    public string Email { get;set; }
    public string Phone { get; set; }

}
