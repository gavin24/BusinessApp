using BusinessApp.Rest.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;
using BusinessApp.Rest.Implementation;

namespace BusinessApp.Rest.Services
{
    public class AppointmentRestService : IAppointmentRestService
    {
        private readonly IAppointmentRestRepository _appointmentRestRepository;
        public AppointmentRestService(IAppointmentRestRepository appointmentRestRepository)
        {
            _appointmentRestRepository = appointmentRestRepository;

        }
        public Task Delete(long id)
        {
            return _appointmentRestRepository.Delete(id, " http://xamBusinessApp.azure.com/appointments/delete");
        }

        public Task<Appointment> Get(long id)
        {
            return _appointmentRestRepository.Get(id, " http://xamBusinessApp.azure.com/appointments/get");
        }

        public Task<IList<Appointment>> GetAllRecords()
        {
            return _appointmentRestRepository.FindAll("", " http://xamBusinessApp.azure.com/appointments/allbydates");
        }

        public Task<IList<Appointment>> GetAppointmentByDate(DateTime appointmentDate)
        {
            return _appointmentRestRepository.FindAllByDate(appointmentDate, " http://xamBusinessApp.azure.com/appointments/allbyuserid");
        }

        public Task<IList<Appointment>> GetAppointmentByUserId(long userId)
        {
            return _appointmentRestRepository.FindAllById(userId, " http://xamBusinessApp.azure.com/appointments/allbyuserid");
        }

        public Task<long> Save(Appointment appointment)
        {
            return _appointmentRestRepository.Save(appointment, "http://xamBusinessApp.azure.com/appointments/");
        }

        public Task SaveOrUpdate(Appointment appointment, long id)
        {
            return _appointmentRestRepository.SaveOrUpdate(id,appointment, "http://xamBusinessApp.azure.com/appointments/update/");
        }
    }
}
