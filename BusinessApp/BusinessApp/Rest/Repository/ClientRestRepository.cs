using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class ClientRestRepository : BaseRestRepository<Client>, IClientRestRepository
    {
        public ClientRestRepository()
        {

        }

        public Task<Client> GetByString(string email, string v)
        {
            throw new NotImplementedException();
        }

        public Client GetClientByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Client GetClientByPhoneNumber(long phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
