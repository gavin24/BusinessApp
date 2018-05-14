using BusinessApp.Models;
using BusinessApp.Rest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Implementation
{
   public interface INotificationRestRepository : IBaseRestRepository<Notification>
    {
        List<Notification> GetAllNotificationsByClientId(long clientId);
        List<Notification> GetAllNotificationsByOrderId(long orderId);
        List<Notification> GetAllNotificationsByUserId(long userId);
    }
}
