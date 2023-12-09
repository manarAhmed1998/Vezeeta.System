using Microsoft.EntityFrameworkCore.Storage;
using Vezeeta.System.DAL.Repos.Appointments;
using Vezeeta.System.DAL.Repos.Times;

namespace Vezeeta.System.DAL;

public class UnitOfWork : IUnitOfWork
{
    private readonly VezeetaContext _context;
    private IDbContextTransaction _transaction;
    public IDoctorsRepo DoctorsRepo { get; }
    public IPatientsRepo PatientsRepo { get; }
    public IAppointmentsRepo AppointmentsRepo { get; }
    public ITimesRepo TimesRepo { get; }

    public UnitOfWork(VezeetaContext context,
        IDoctorsRepo doctorsRepo,
        IPatientsRepo patientsRepo,
        IAppointmentsRepo appointmentsRepo,
        ITimesRepo timesRepo
        )
    {
        _context = context;
        DoctorsRepo = doctorsRepo;
        PatientsRepo = patientsRepo;
        AppointmentsRepo = appointmentsRepo;
        TimesRepo = timesRepo;
    }


    public int Save()
    {
        return _context.SaveChanges();
    }

    public IDbContextTransaction BeginTransaction()
    {
        _transaction = _context.Database.BeginTransaction();
        return _transaction;
    }

    public void Commit()
    {
        _transaction?.Commit();
    }

    public void Rollback()
    {
        _transaction?.Rollback();
    }

    public void Dispose()
    {
        _transaction?.Dispose();
        _context.Dispose();
    }
}
