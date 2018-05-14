using BusinessApp.Models;
using BusinessApp.Rest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Implementation
{
   public interface IUserRestRepository : IBaseRestRepository<User>
    {
        User GetUserByEmail(string email);
        User GetUserByPhoneNumber(long phoneNumber);
        Task<User> GetByString(string email, string v);
    }
}
