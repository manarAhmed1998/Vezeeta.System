using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.DAL;

namespace Vezeeta.System.BL;

public class PatientsManager:IPatientsManager
{
    private readonly PatientsRepo _patientsRepo;

    public PatientsManager(PatientsRepo patientsRepo)
    {
        _patientsRepo = patientsRepo;
    }
}
