using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;
public class Doctor:ApplicationUser
{
    public new AccountType AccountType = AccountType.Doctor;

    public new Image Image = null!;
    public ApplicationUser ApplicationUser { get; set; } = null!;
    public Guid SpecializationId { get; set; }
    public int Price { get; set; }
    public Specialization Specialization { get; set; } = null!;
    public ICollection<Appointment> Appointments { get; set; } = null!;

}
