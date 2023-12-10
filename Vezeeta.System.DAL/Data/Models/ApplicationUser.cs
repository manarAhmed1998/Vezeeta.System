using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class ApplicationUser:IdentityUser
{
    public virtual Doctor Doctor { get; set; }= null!;
    public virtual Patient Patient { get; set; } = null!;
    public AccountType AccountType { get; set; }

    public static implicit operator Task<object>(ApplicationUser v)
    {
        throw new NotImplementedException();
    }
}
