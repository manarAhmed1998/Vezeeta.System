using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class PatientsRepo:GenericReop<Patient>,IPatientsRepo
{
    private readonly VezeetaContext _context;
    public PatientsRepo(VezeetaContext context):base(context)
    {
        _context = context;
    }
}
