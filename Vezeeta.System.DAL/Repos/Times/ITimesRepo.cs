using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL.Repos.Times
{
    public interface ITimesRepo : IGenericRepo<Time>
    {
        void AddRange(List<Time> times);
    }
}
