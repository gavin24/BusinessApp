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
   public class ProductRepository : BaseRepository<Products>, IProductRepository
    {
        private readonly SQLiteConnection conn;
        public ProductRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Products>();
        }

       public List<Products> GetProductsByCategoryId(long categoryId)
       {
           throw new NotImplementedException();
       }
    }
}
