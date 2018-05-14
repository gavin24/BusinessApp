using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using BusinessApp.Repositories;
using SQLite;
using Xamarin.Forms;
using SQLite.Net;

namespace BusinessApp.Services
{
   public class EnqueriesRepository : BaseRepository<Enqueries>, IEnqueriesRepository
    {
        private readonly SQLiteConnection conn;
        public EnqueriesRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Enqueries>();
        }

       public List<Enqueries> GetAllEnqueriesByClientId(long clientId)
       {
           throw new NotImplementedException();
       }
    }
}
