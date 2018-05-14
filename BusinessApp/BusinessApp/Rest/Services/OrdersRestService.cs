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
    public class OrdersRestService : IOrderRestService
    {
        private readonly IOrderRestRepository _orderRestRepository;
        public OrdersRestService(IOrderRestRepository orderRestRepository)
        {
            _orderRestRepository = orderRestRepository;

        }
        public Task Delete(long id)
        {
            return _orderRestRepository.Delete(id, "http://xamBusinessApp.azure.com/orders/delete/");
        }

        public Task<Orders> Get(long id)
        {
            return _orderRestRepository.Get(id, "http://xamBusinessApp.azure.com/orders/get/");
        }

        public Task<IList<Orders>> GetAllRecords()
        {
            return _orderRestRepository.FindAll("", "http://xamBusinessApp.azure.com/orders/all/");
        }

        public Task<IList<Orders>> GetOrdesByClientId(long clientId)
        {
            return _orderRestRepository.FindAllById(clientId, "http://xamBusinessApp.azure.com/orders/allbyclientid/");
        }

        public Task<long> Save(Orders orders)
        {
            return _orderRestRepository.Save(orders, "http://xamBusinessApp.azure.com/orders");
        }

        public Task SaveOrUpdate(Orders orders, long id)
        {
            return _orderRestRepository.SaveOrUpdate(id, orders, "http://xamBusinessApp.azure.com/orders/update/");
        }
    }
}
