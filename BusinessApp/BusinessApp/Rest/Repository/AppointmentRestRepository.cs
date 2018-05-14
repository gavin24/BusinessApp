using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class AppointmentRestRepository : BaseRestRepository<Appointment>, IAppointmentRestRepository
    {
        public AppointmentRestRepository()
        {

        }
        public List<Appointment> GetAppointmentByDate(DateTime appointmentDate)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAppointmentByUserId(long userId)
        {
            throw new NotImplementedException();
        }
    }
}
