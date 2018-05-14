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
   public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        private readonly SQLiteConnection conn;
        public LocationRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Location>();
        }

       public Location GetLocationByCustomerId(long customerId)
       {
           throw new NotImplementedException();
       }
    }
}
