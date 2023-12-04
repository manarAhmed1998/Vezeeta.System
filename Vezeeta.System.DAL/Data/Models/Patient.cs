using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class Patient:ApplicationUser
{
    public new AccountType AccountType= AccountType.Patient;
    public ApplicationUser ApplicationUser { get; set; } = null!;
    public ICollection<Booking>? Bookings { get; set; }
}
