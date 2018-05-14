using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class AccountRestRepository : BaseRestRepository<Account>, IAccountRestRepository
    {
        public AccountRestRepository()
        {

        }

        public List<Account> GetAccountsByUserId(long userId)
        {
            throw new NotImplementedException();
        }
    }
}
