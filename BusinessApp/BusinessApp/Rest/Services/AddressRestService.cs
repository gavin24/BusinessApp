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
    public class AddressRestService : IAddressRestService
    {
        private readonly IAddressRestRepository _addressRestRepository;
        public AddressRestService(IAddressRestRepository addressRestRepository)
        {
            _addressRestRepository = addressRestRepository;

        }
        public Task Delete(long id)
        {
            return _addressRestRepository.Delete(id, "http://xamBusinessApp.azure.com/address/delete");
        }

        public Task<Address> Get(long id)
        {
            return _addressRestRepository.Get(id, "http://xamBusinessApp.azure.com/address/get");
        }

        public Task<Address> GetAddressByUserId(long userId)
        {
            return _addressRestRepository.Get(userId, "http://xamBusinessApp.azure.com/address/allbyuserid/");
        }

        public Task<IList<Address>> GetAllRecords()
        {
            return _addressRestRepository.FindAll("", "http://xamBusinessApp.azure.com/address/all/");
        }

        public Task<long> Save(Address address)
        {
            return _addressRestRepository.Save(address, "http://xamBusinessApp.azure.com/address");
        }

        public Task SaveOrUpdate(Address address, long id)
        {
            throw new NotImplementedException();
        }

        public Task SaveOrUpdate(long id, Address address)
        {
            return _addressRestRepository.SaveOrUpdate(id, address, "http://xamBusinessApp.azure.com/address/update/");
        }
    }
}
