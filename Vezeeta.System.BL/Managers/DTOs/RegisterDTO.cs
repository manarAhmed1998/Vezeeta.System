using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.BL.Managers.DTOs
{
    public class RegisterDTO
    {
        public string UserName { get; init; } = null!;
        public string Email { get; init; } = null!;
        public string Password { get; init; } = null!;
        public string Name { get; init; } = null!;
        public string Img { get; init; } = null!;
        public Guid SpecializationId {  get; init; }
    }
}
