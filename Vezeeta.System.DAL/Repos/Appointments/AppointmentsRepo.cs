using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL.Repos.Appointments
{
    public class AppointmentsRepo : GenericReop<Appointment>, IAppointmentsRepo
    {
        private readonly VezeetaContext _context;
        public AppointmentsRepo(VezeetaContext context) :base(context)
        {
            _context = context;
        }
    }
}
