using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;
public class Doctor:ApplicationUser
{

    public ApplicationUser ApplicationUser { get; set; } = null!;

    public new AccountType AccountType = AccountType.Doctor;

    //one-to-one optional key should be in the mandatory
    [ForeignKey("ApplicationUser")]
    public string ApplicationUserId { get; set; } = null!;

    public new Image Image = null!;
    public Guid SpecializationId { get; set; }
    public int Price { get; set; }
    public Specialization Specialization { get; set; } = null!;
    public ICollection<Appointment> Appointments { get; set; } = null!;

}
