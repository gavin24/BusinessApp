using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class NotificationRestRepository : BaseRestRepository<Notification>, INotificationRestRepository
    {
        public NotificationRestRepository()
        {

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
