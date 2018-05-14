using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using SQLite;
using Xamarin.Forms;
using SQLite.Net;

namespace BusinessApp.Repositories
{
   public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        private readonly SQLiteConnection conn;
        public AccountRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Account>();
        }

       public List<Account> GetAccountsByUserId(long userId)
       {
           throw new NotImplementedException();
       }
    }
}
