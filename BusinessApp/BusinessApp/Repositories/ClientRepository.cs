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
   public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        private readonly SQLiteConnection conn;
        public ClientRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Client>();
        }

       public Client GetClientByEmail(string email)
       {
           throw new NotImplementedException();
       }

       public Client GetClientByPhoneNumber(long phoneNumber)
       {
           throw new NotImplementedException();
       }
    }
}
