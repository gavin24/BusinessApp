using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;
namespace BusinessApp.Rest.Services.Implementation
{
   public interface IAccountRestService
    {
        Task<IList<Account>> GetAccountsByUserId(long userId);
        Task Delete(long id);
        Task SaveOrUpdate(long id,Account account);
        Task<long> Save(Account account);
        Task<IList<Account>> GetAllRecords();
        Task<Account> Get(long id);
    }
}
