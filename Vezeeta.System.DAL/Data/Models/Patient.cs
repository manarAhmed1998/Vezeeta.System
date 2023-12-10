using System.ComponentModel.DataAnnotations.Schema;
using Vezeeta.System.DAL;

namespace Vezeeta.System.DAL;
public class Patient:User
{
    //one-to-one optional key should be in the mandatory
    [ForeignKey("ApplicationUser")]
    public string ApplicationUserId { get; set; } = null!;
    public ApplicationUser ApplicationUser { get; set; } = null!;
    public ICollection<Booking>? Bookings { get; set; }
    public ICollection<PatientCoupon>? PatientCoupons { get; set; }
    public Gender Gender {  get; set; }
}
