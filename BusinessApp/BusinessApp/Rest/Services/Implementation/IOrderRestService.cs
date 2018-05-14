using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface IOrderRestService
    {
        Task<IList<Orders>> GetOrdesByClientId(long clientId);
        Task Delete(long id);
        Task SaveOrUpdate(Orders orders,long id);
        Task<long> Save(Orders orders);
        Task<IList<Orders>> GetAllRecords();
        Task<Orders> Get(long id);
    }
}
