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
   public class BillRepository : BaseRepository<Bill>, IBillRepository
    {
        private readonly SQLiteConnection conn;
        public BillRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Bill>();
        }

       public List<Bill> GetBillsByClientId(long clientId)
       {
           throw new NotImplementedException();
       }
    }
}
