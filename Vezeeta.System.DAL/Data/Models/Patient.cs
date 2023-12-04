using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class Patient:ApplicationUser
{
    //one-to-one optional key should be in the mandatory
    [ForeignKey("ApplicationUser")]
    public string ApplicationUserId { get; set; } = null!;
    public new AccountType AccountType= AccountType.Patient;
    public ApplicationUser ApplicationUser { get; set; } = null!;
    public ICollection<Booking>? Bookings { get; set; }
}
