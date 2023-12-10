using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.BL.DTOs.Patients
{
    public class AddPatientDTO
    {
        public string UserName { get; init; } = null!;
        public string Email { get; init; } = null!;
        public string Password { get; init; } = null!;
        public string Img { get; init; } = null!;

    }
}
