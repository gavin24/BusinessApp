using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface IAppointmentRestService
    {
        Task<IList<Appointment>> GetAppointmentByUserId(long userId);
        Task<IList<Appointment>> GetAppointmentByDate(DateTime appointmentDate);
        Task Delete(long id);
        Task SaveOrUpdate(Appointment appointment,long id);
        Task<long> Save(Appointment appointment);
        Task<IList<Appointment>> GetAllRecords();
        Task<Appointment> Get(long id);
    }
}
