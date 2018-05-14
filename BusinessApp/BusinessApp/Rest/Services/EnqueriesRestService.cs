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
    public class EnqueriesRestService : IEnqueriesRestService
    {
        private readonly IEnqueriesRestRepository _enqueriesRestRepository;
        public EnqueriesRestService(IEnqueriesRestRepository enqueriesRestRepository)
        {
            _enqueriesRestRepository = enqueriesRestRepository;

        }
        public Task Delete(long id)
        {
            return _enqueriesRestRepository.Delete(id, "http://xamBusinessApp.azure.com/enqueries/delete/");
        }

        public Task<Enqueries> Get(long id)
        {
            return _enqueriesRestRepository.Get(id, "http://xamBusinessApp.azure.com/enqueries/get/");
        }

        public Task<IList<Enqueries>> GetAllEnqueriesByClientId(long clientId)
        {
            return _enqueriesRestRepository.FindAllById(clientId, "http://xamBusinessApp.azure.com/enqueries/allbyclientid/");
        }

        public Task<IList<Enqueries>> GetAllRecords()
        {
            return _enqueriesRestRepository.FindAll("", "http://xamBusinessApp.azure.com/enqueries/all/");
        }

        public Task<long> Save(Enqueries enqueries)
        {
            return _enqueriesRestRepository.Save(enqueries, "http://xamBusinessApp.azure.com/enqueries");
        }

        public Task SaveOrUpdate(Enqueries enqueries, long id)
        {
            return _enqueriesRestRepository.SaveOrUpdate(id, enqueries, "http://xamBusinessApp.azure.com/enqueries/update/");
        }
    }
}
