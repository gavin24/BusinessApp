using BusinessApp.Rest.Implementation;
using BusinessApp.Rest.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Rest.Services
{
    public class AccountRestService : IAccountRestService
    {
        private readonly IAccountRestRepository _accountRestRepository;
        public AccountRestService(IAccountRestRepository accountRestRepository)
        {
            _accountRestRepository = accountRestRepository;

        }
        string baseUrl = "http://xamBusinessApp.azure.com/accounts/";
        public Task Delete(long id)
        {
            return _accountRestRepository.Delete(id, "http://xamBusinessApp.azure.com/accounts/delete/");
        }
      
        public Task<Account> Get(long id)
        {
            return _accountRestRepository.Get(id, "http://xamBusinessApp.azure.com/accounts/get/");
        }

        public Task<IList<Account>> GetAccountsByUserId(long userId)
        {
           return _accountRestRepository.FindAllById(userId, "http://xamBusinessApp.azure.com/accounts/allbyuserid/");
        }

        public Task<IList<Account>> GetAllRecords()
        {
           return _accountRestRepository.FindAll("","http://xamBusinessApp.azure.com/accounts/all/");
        }

        public Task<long> Save(Account account)
        {
            return _accountRestRepository.Save(account,"http://xamBusinessApp.azure.com/accounts");
        }

        public Task SaveOrUpdate(long id,Account account)
        {
           return _accountRestRepository.SaveOrUpdate(id, account, "http://xamBusinessApp.azure.com/accounts/update/");
        }
    }
}
