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
   public class OrdersRepository : BaseRepository<Orders>, IOrdersRepository
    {
        private readonly SQLiteConnection conn;
        public OrdersRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Orders>();
        }

       public List<Orders> GetOrdesByClientId(long clientId)
       {
           throw new NotImplementedException();
       }
    }
}
