using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class UserRestRepository : BaseRestRepository<User>, IUserRestRepository
    {
        public UserRestRepository()
        {

        }

        public Task<User> GetByString(string email, string v)
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User GetUserByPhoneNumber(long phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
