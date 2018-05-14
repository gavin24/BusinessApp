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
   public class ContactInfoEntity
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private string Email { get; set; }
        private long PhoneNumber { get; set; }
        private string SecondaryEmail { get; set; }
    }
}
