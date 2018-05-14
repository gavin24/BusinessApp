using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface ILocationRestService
    {
        Task<Location> GetLocationByCustomerId(long customerId);
        Task Delete(long id);
        Task SaveOrUpdate(Location location,long id);
        Task<long> Save(Location location);
        Task<IList<Location>> GetAllRecords();
        Task<Location> Get(long id);
    }
}
