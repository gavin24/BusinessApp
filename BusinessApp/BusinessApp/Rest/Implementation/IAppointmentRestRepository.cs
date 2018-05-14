using BusinessApp.Models;
using BusinessApp.Rest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Implementation
{
   public interface IAppointmentRestRepository : IBaseRestRepository<Appointment>
    {
        List<Appointment> GetAppointmentByUserId(long userId);
        List<Appointment> GetAppointmentByDate(DateTime appointmentDate);
        Task<IList<Appointment>> FindAllByDate(DateTime appointmentDate, string v);
    }
}
