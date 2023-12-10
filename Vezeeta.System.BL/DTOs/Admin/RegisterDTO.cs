using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.DAL;

namespace Vezeeta.System.BL.DTOs.Admin
{
    public class RegisterDTO
    {
        public string UserName { get; init; } = null!;
        public string Email { get; init; } = null!;
        public string Password { get; init; } = null!;
        public string Name { get; init; } = null!;
        public string Img { get; init; } = null!;
        public Guid SpecializationId { get; init; }
        public Gender Gender { get; init; }
    }
}
