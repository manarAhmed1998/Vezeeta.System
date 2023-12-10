using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.DAL;

namespace Vezeeta.System.BL;

public class DoctorReadDTO
{
    public required string? Img { get; set; }
    public required string Name { get; set; } = string.Empty;
    public required Gender Gender { get; set; }
}
