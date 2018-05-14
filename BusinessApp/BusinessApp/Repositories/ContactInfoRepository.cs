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
  public class ContactInfoRepository : BaseRepository<ContactInfo>, IContactInfoRepository
    {
        private readonly SQLiteConnection conn;
        public ContactInfoRepository() : base()
      {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<ContactInfo>();
        }

      public ContactInfo GetContactInfoByClientId(long clientId)
      {
          throw new NotImplementedException();
      }
    }
}
