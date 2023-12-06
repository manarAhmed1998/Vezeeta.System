using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class DoctorsRepo : GenericReop<Doctor>,IDoctorsRepo
{
    private readonly VezeetaContext _context;
    public DoctorsRepo(VezeetaContext context):base(context)
    {
         _context = context;
    } 
}
