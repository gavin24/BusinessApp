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
   public class UserEntity
    {
        private long Id { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private long PhoneNumber { get; set; }
    }
}
