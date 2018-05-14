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
   public class ImagesRepository : BaseRepository<Images>, IImagesRepository
    {
        private readonly SQLiteConnection conn;
        public ImagesRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Images>();
        }

       public Images GetImageByProductId(long productId)
       {
           throw new NotImplementedException();
       }

       public Images GetImageByClientId(long clientId)
       {
           throw new NotImplementedException();
       }

       public Images GetImageByUserId(long userId)
       {
           throw new NotImplementedException();
       }
    }
}
