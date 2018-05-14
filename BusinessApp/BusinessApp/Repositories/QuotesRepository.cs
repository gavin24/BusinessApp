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
   public class QuotesRepository : BaseRepository<Quotes>, IQuotesRepository
    {
        private readonly SQLiteConnection conn;
        public QuotesRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Quotes>();
        }

       public List<Quotes> GetQuotesByClientId(long clientId)
       {
           throw new NotImplementedException();
       }

       public List<Quotes> GetQuotesByUserId(long userId)
       {
           throw new NotImplementedException();
       }
    }
}
