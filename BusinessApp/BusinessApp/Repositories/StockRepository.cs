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
   public class StockRepository : BaseRepository<Stock>, IStockRepository
    {
        private readonly SQLiteConnection conn;
        public StockRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Stock>();
        }

       public Stock GetStockByProductId(long productId)
       {
           throw new NotImplementedException();
       }
    }
}
