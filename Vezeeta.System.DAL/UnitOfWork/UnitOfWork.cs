using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class UnitOfWork : IUnitOfWork
{
    private readonly VezeetaContext _context;
    private IDbContextTransaction _transaction;
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
