using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using BusinessApp.Enums;
namespace BusinessApp.Entities
{
   public class ClientEntity
    {
        private long Id { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private long PhoneNumber { get; set; }
        private string name { get; set; }
        private string Surname { get; set; }
        private IList<Address> ClientAddress { get; set; }
    }
}
