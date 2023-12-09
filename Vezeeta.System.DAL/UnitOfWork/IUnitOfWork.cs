using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.DAL.Repos.Appointments;
using Vezeeta.System.DAL.Repos.Times;

namespace Vezeeta.System.DAL;

public interface IUnitOfWork : IDisposable
{
    //this bag has all of your repos and saveChanges method
    //only getting repos so no set; needed
    IDbContextTransaction BeginTransaction();
    void Commit();
    void Rollback();
    public IDoctorsRepo DoctorsRepo { get; }
    public IPatientsRepo PatientsRepo { get;}
    public IAppointmentsRepo AppointmentsRepo { get; }
    public ITimesRepo TimesRepo { get; }
    int Save();
}
