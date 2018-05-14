using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface INotificationRestService
    {
        Task<IList<Notification>> GetAllNotificationsByClientId(long clientId);
        Task<IList<Notification>> GetAllNotificationsByOrderId(long orderId);
        Task<IList<Notification>> GetAllNotificationsByUserId(long userId);
        Task Delete(long id);
        Task SaveOrUpdate(Notification notification,long id);
        Task<long> Save(Notification notification);
        Task<IList<Notification>> GetAllRecords();
        Task<Notification> Get(long id);
    }
}
