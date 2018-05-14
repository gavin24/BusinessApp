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
   public class OrderLineRepository : BaseRepository<OrderLine>, IOrderLineRepository
    {
        private readonly SQLiteConnection conn;
        public OrderLineRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<OrderLine>();
        }

       public OrderLine GetOrderLineByOrderId(long orderId)
       {
           throw new NotImplementedException();
       }
    }
}
