using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class OrderLineRestRepository : BaseRestRepository<OrderLine>, IOrderLineRestRepository
    {
        public OrderLineRestRepository()
        {

        }
        public OrderLine GetOrderLineByOrderId(long orderId)
        {
            throw new NotImplementedException();
        }
    }
}
