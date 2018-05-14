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
    public class ClientRestService : IClientRestService
    {
        private readonly IClientRestRepository _clientRestRepository;
        public ClientRestService(IClientRestRepository clientRestRepository)
        {
            _clientRestRepository = clientRestRepository;

        }
        public Task Delete(long id)
        {
            return _clientRestRepository.Delete(id, "http://xamBusinessApp.azure.com/clients/delete/");
        }

        public Task<Client> Get(long id)
        {
            return _clientRestRepository.Get(id, "http://xamBusinessApp.azure.com/clients/get/");
        }

        public Task<IList<Client>> GetAllRecords()
        {
            return _clientRestRepository.FindAll("", "http://xamBusinessApp.azure.com/clients/all/");
        }

        public Task<Client> GetClientByEmail(string email)
        {
            return _clientRestRepository.GetByString(email, "http://xamBusinessApp.azure.com/clients/allbyuseremail/");
        }

        public Task<Client> GetClientByPhoneNumber(long phoneNumber)
        {
            return _clientRestRepository.Get(phoneNumber, "http://xamBusinessApp.azure.com/clients/allbyclientid/");
        }

        public Task<long> Save(Client client)
        {
            return _clientRestRepository.Save(client, "http://xamBusinessApp.azure.com/clients");
        }

        public Task SaveOrUpdate(Client client, long id)
        {
            return _clientRestRepository.SaveOrUpdate(id, client, "http://xamBusinessApp.azure.com/clients/update/");
        }
    }
}
