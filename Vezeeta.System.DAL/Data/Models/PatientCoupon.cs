using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class PatientCoupon
{
    
    public Guid PatientId { get; set; }
    public Guid CouponId { get; set; }
    public Patient Patient { get; set; }
    public Coupon Coupon { get; set; }
}
