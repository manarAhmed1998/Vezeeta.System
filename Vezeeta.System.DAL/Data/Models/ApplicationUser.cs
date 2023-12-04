using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class ApplicationUser
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Image? Image { get; set; }
    public AccountType AccountType { get; set; }

    public Patient Patient { get; set; } = null!;
    public Doctor Doctor { get; set; }= null!;
}
