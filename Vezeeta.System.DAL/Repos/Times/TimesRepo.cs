using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL.Repos.Times
{
    public class TimesRepo : GenericReop<Time>, ITimesRepo
    {
        private readonly VezeetaContext _context;

        public TimesRepo(VezeetaContext context):base(context)
        {
            _context = context;
        }
        public void AddRange(List<Time> times) 
        {
            _context.Set<Time>().AddRange(times);
        }
    }
}
