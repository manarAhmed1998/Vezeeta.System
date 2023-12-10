using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.BL.DTOs.Admin;

namespace Vezeeta.System.BL.Managers.Admin
{
    public interface IAdminManager
    {
        Task<bool> AddDoctor(RegisterDTO credentials);
    }
}
