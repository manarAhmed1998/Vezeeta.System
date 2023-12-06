using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class UnitOfWork : IUnitOfWork
{
    private readonly VezeetaContext _context;
    public IDoctorsRepo DoctorsRepo { get; }
    public IPatientsRepo PatientsRepo { get; }

    public UnitOfWork(VezeetaContext context,
        IDoctorsRepo doctorsRepo,
        IPatientsRepo patientsRepo)
    {
        _context = context;
        DoctorsRepo = doctorsRepo;
        PatientsRepo = patientsRepo;
    }


    public int Save()
    {
        return _context.SaveChanges();
    }
}
