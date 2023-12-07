using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.BL.Managers.DTOs;

namespace Vezeeta.System.BL;

public interface IPatientsManager
{
    Task<bool> AddPatient(AddPatientDTO credentials);
}
