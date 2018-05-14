using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface IUserRestService
    {
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserByPhoneNumber(long phoneNumber);
        Task Delete(long id);
        Task SaveOrUpdate(User user,long id);
        Task<long> Save(User user);
        Task<IList<User>> GetAllRecords();
        Task<User> Get(long id);
    }
}
