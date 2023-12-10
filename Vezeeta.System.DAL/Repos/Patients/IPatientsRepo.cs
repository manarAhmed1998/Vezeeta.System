using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public interface IPatientsRepo : IGenericRepo<Patient>
{
    int Count();
}
