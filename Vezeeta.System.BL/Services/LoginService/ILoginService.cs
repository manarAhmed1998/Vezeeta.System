using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.BL.DTOs.Admin;

namespace Vezeeta.System.BL.Services.LoginService
{
    public interface ILoginService
    {
        Task<TokenDTO> Login(LoginDTO credentials);
    }
}
