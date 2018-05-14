using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface IBillRestService
    {
        Task<IList<Bill>> GetBillsByClientId(long clientId);
        Task Delete(long id);
        Task SaveOrUpdate(Bill bill,long id);
        Task<long> Save(Bill bill);
        Task<IList<Bill>> GetAllRecords();
        Task<Bill> Get(long id);
    }
}
