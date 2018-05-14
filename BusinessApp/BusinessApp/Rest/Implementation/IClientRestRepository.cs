using BusinessApp.Models;
using BusinessApp.Rest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Implementation
{
   public interface IClientRestRepository : IBaseRestRepository<Client>
    {
        Client GetClientByEmail(string email);
        Client GetClientByPhoneNumber(long phoneNumber);
        Task<Client> GetByString(string email, string v);
    }
}
