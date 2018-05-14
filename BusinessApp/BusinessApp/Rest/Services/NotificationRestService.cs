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
    public class NotificationRestService : INotificationRestService
    {
        private readonly INotificationRestRepository _notRestRepository;
        public NotificationRestService(INotificationRestRepository notRestRepository)
        {
            _notRestRepository = notRestRepository;

        }
        public Task Delete(long id)
        {
            return _notRestRepository.Delete(id, "http://xamBusinessApp.azure.com/notifications/delete/");
        }

        public Task<Notification> Get(long id)
        {
            return _notRestRepository.Get(id, "http://xamBusinessApp.azure.com/notifications/get/");
        }

        public Task<IList<Notification>> GetAllNotificationsByClientId(long clientId)
        {
            return _notRestRepository.FindAllById(clientId, "http://xamBusinessApp.azure.com/notifications/allbyclientid/");
        }

        public Task<IList<Notification>> GetAllNotificationsByOrderId(long orderId)
        {
            return _notRestRepository.FindAllById(orderId, "http://xamBusinessApp.azure.com/notifications/allbyorderid/");
        }

        public Task<IList<Notification>> GetAllNotificationsByUserId(long userId)
        {
            return _notRestRepository.FindAllById(userId, "http://xamBusinessApp.azure.com/notifications/allbyuserid/");
        }

        public Task<IList<Notification>> GetAllRecords()
        {
            return _notRestRepository.FindAll("", "http://xamBusinessApp.azure.com/notifications/all/");
        }

        public Task<long> Save(Notification notification)
        {
            return _notRestRepository.Save(notification, "http://xamBusinessApp.azure.com/notifications");
        }

        public Task SaveOrUpdate(Notification notification, long id)
        {
            return _notRestRepository.SaveOrUpdate(id, notification, "http://xamBusinessApp.azure.com/notifications/update/");
        }
    }
}
