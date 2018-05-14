using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using BusinessApp.Rest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface IClientRestService 
    {
        Task<Client> GetClientByEmail(string email);
        Task<Client> GetClientByPhoneNumber(long phoneNumber);
        Task Delete(long id);
        Task SaveOrUpdate(Client client,long id);
        Task<long> Save(Client client);
        Task<IList<Client>> GetAllRecords();
        Task<Client> Get(long id);
    }
}
