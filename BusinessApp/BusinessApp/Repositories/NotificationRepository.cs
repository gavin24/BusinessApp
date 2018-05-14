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
   public class NotificationRepository : BaseRepository<Notification>, INotificationRepository
    {
        private readonly SQLiteConnection conn;
        public NotificationRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Notification>();
        }

       public List<Notification> GetAllNotificationsByClientId(long clientId)
       {
           throw new NotImplementedException();
       }

       public List<Notification> GetAllNotificationsByOrderId(long orderId)
       {
           throw new NotImplementedException();
       }

       public List<Notification> GetAllNotificationsByUserId(long userId)
       {
           throw new NotImplementedException();
       }
    }
}
