using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using SQLite;
using Xamarin.Forms;
using SQLite.Net;

namespace BusinessApp.Repositories
{
   public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
    {
        private readonly SQLiteConnection conn;
        public AppointmentRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Appointment>();
        }

       public List<Appointment> GetAppointmentByUserId(long userId)
       {
           throw new NotImplementedException();
       }

       public List<Appointment> GetAppointmentByDate(DateTime appointmentDate)
       {
           throw new NotImplementedException();
       }
    }
}
