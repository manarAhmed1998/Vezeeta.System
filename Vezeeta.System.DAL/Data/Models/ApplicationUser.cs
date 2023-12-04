using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class ApplicationUser:IdentityUser
{
    //hiding id of the IdentityUser
    public new Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Image? Image { get; set; }
    public AccountType AccountType { get; set; }

    public Patient Patient { get; set; } = null!;
    public Doctor Doctor { get; set; }= null!;
}
