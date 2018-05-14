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
   public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        private readonly SQLiteConnection conn;
        public CartRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Cart>();
        }

       public Cart GetCartByClientId(long clientId)
       {
           throw new NotImplementedException();
       }
    }
}
