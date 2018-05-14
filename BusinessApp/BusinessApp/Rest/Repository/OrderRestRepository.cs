using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class OrderRestRepository : BaseRestRepository<Orders>, IOrderRestRepository
    {
        public OrderRestRepository()
        {

        }
        public List<Orders> GetOrdesByClientId(long clientId)
        {
            throw new NotImplementedException();
        }
    }
}
