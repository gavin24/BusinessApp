using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface IEnqueriesRestService
    {
        Task<IList<Enqueries>> GetAllEnqueriesByClientId(long clientId);
        Task Delete(long id);
        Task SaveOrUpdate(Enqueries enqueries,long id);
        Task<long> Save(Enqueries enqueries);
        Task<IList<Enqueries>> GetAllRecords();
        Task<Enqueries> Get(long id);
    }
}
