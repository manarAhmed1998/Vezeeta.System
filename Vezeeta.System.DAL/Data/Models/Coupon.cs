using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class Coupon
{
    public Guid Id {  get; set; }
    public string DiscountCode { get; set; }
    public DiscountType DiscountType { get; set; }
    public double Value { get; set; }
    public bool Status {  get; set; }
    public ICollection<PatientCoupon>? PatientCoupons { get; set; }

}
