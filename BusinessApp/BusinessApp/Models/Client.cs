using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLite.Net.Attributes;

namespace BusinessApp.Models
{
    public class Client : Model
    {
        [PrimaryKey, AutoIncrement]
        private long Id { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private long PhoneNumber { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private long ClientAddressId { get; set; }
     //   private IList<Address> ClientAddress { get; set; }
    }
}