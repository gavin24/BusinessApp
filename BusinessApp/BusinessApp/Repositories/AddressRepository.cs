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
  public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        private readonly SQLiteConnection conn;
        public AddressRepository() : base()
      {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Address>();
        }

      public Address GetAddressByUserId(long userId)
      {
          throw new NotImplementedException();
      }
    }
}
