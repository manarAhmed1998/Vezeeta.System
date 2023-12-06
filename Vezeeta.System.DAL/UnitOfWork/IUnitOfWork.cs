using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public interface IUnitOfWork
{
    //this bag has all of your repos and saveChanges method
    //only getting repos so no set; needed
    public IDoctorsRepo DoctorsRepo { get; }
    public IPatientsRepo PatientsRepo { get;}
    int Save();
}
