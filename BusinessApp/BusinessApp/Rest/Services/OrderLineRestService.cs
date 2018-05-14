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
    public class OrderLineRestService : IOrderLineRestService
    {
        private readonly IOrderLineRestRepository _orderLineRestRepository;
        public OrderLineRestService(IOrderLineRestRepository orderLineRestRepository)
        {
            _orderLineRestRepository = orderLineRestRepository;

        }
        public Task Delete(long id)
        {
            return _orderLineRestRepository.Delete(id, "http://xamBusinessApp.azure.com/orderline/delete/");
        }

        public Task<OrderLine> Get(long id)
        {
            return _orderLineRestRepository.Get(id, "http://xamBusinessApp.azure.com/orderline/get/");
        }

        public Task<IList<OrderLine>> GetAllRecords()
        {
            return _orderLineRestRepository.FindAll("", "http://xamBusinessApp.azure.com/orderline/all/");
        }

        public Task<OrderLine> GetOrderLineByOrderId(long orderId)
        {
            return _orderLineRestRepository.Get(orderId, "http://xamBusinessApp.azure.com/orderline/allbyorderid/");
        }

        public Task<long> Save(OrderLine orderLineModel)
        {
            return _orderLineRestRepository.Save(orderLineModel, "http://xamBusinessApp.azure.com/orderline");
        }

        public Task SaveOrUpdate(OrderLine orderLineModel, long id)
        {
            return _orderLineRestRepository.SaveOrUpdate(id, orderLineModel, "http://xamBusinessApp.azure.com/orderline/update/");
        }
    }
}
