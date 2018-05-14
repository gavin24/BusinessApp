using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface IOrderLineRestService
    {
        Task<OrderLine> GetOrderLineByOrderId(long orderId);
        Task Delete(long id);
        Task SaveOrUpdate(OrderLine orderLineModel,long id);
        Task<long> Save(OrderLine orderLineModel);
        Task<IList<OrderLine>> GetAllRecords();
        Task<OrderLine> Get(long id);
    }
}
