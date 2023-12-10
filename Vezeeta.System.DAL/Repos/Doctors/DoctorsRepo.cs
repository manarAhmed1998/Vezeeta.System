using Microsoft.EntityFrameworkCore;
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

    public int Count()
    {
        return _context.Doctors.Count();
    }

    public IEnumerable<Doctor> GetAllDoctorsWithSettings()
    {
        return _context.Doctors
            .Include(d => d.Appointments)
            .ThenInclude(a => a.Day)
            .Include(d => d.Appointments)
            .ThenInclude(a => a.Times);
    }
}
