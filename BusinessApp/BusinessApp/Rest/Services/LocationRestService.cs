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
    public class LocationRestService : ILocationRestService
    {
        private readonly ILocationRestRepository _locationRestRepository;
        public LocationRestService(ILocationRestRepository locationRestRepository)
        {
            _locationRestRepository = locationRestRepository;

        }
        public Task Delete(long id)
        {
            return _locationRestRepository.Delete(id, "http://xamBusinessApp.azure.com/locations/delete/");
        }

        public Task<Location> Get(long id)
        {
            return _locationRestRepository.Get(id, "http://xamBusinessApp.azure.com/locations/get/");
        }

        public Task<IList<Location>> GetAllRecords()
        {
            return _locationRestRepository.FindAll("", "http://xamBusinessApp.azure.com/locations/all/");
        }

        public Task<Location> GetLocationByCustomerId(long customerId)
        {
            return _locationRestRepository.Get(customerId, "http://xamBusinessApp.azure.com/locations/allbycustomerid");
        }

        public Task<long> Save(Location location)
        {
            return _locationRestRepository.Save(location, "http://xamBusinessApp.azure.com/locations");
        }

        public Task SaveOrUpdate(Location location, long id)
        {
            return _locationRestRepository.SaveOrUpdate(id, location, "http://xamBusinessApp.azure.com/locations/update/");
        }
    }
}
