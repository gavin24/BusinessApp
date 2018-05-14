using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface IAddressRestService
    {
        Task<Address> GetAddressByUserId(long userId);
        Task Delete(long id);
        Task SaveOrUpdate(Address address, long id);
        Task<long> Save(Address address);
        Task<IList<Address>> GetAllRecords();
        Task<Address> Get(long id);
    }
}
