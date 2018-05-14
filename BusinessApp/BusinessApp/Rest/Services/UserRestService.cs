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
    public class UserRestService : IUserRestService
    {
        private readonly IUserRestRepository _userRestRepository;
        public UserRestService(IUserRestRepository userRestRepository)
        {
            _userRestRepository = userRestRepository;

        }
        public Task Delete(long id)
        {
            return _userRestRepository.Delete(id, "http://xamBusinessApp.azure.com/user/delete/");
        }

        public Task<User> Get(long id)
        {
            return _userRestRepository.Get(id, "http://xamBusinessApp.azure.com/user/get/");
        }

        public Task<IList<User>> GetAllRecords()
        {
            return _userRestRepository.FindAll("", "http://xamBusinessApp.azure.com/user/all/");
        }

        public Task<User> GetUserByEmail(string email)
        {
            return _userRestRepository.GetByString(email, "http://xamBusinessApp.azure.com/user/allbyemailid/");
        }
        
        public Task<User> GetUserByPhoneNumber(long phoneNumber)
        {
            return _userRestRepository.Get(phoneNumber, "http://xamBusinessApp.azure.com/user/allbynumberid/");
        }

        public Task<long> Save(User user)
        {
            return _userRestRepository.Save(user, "http://xamBusinessApp.azure.com/user");
        }

        public Task SaveOrUpdate(User user, long id)
        {
            return _userRestRepository.SaveOrUpdate(id, user, "http://xamBusinessApp.azure.com/user/update/");
        }
    }
}
