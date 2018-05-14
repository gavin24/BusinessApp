using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using BusinessApp.Enums;
namespace BusinessApp.entities
{
   public class AccountEntity
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private string AccountName { get; set; }
        private IList<Orders> OrdersList { get; set; }
        private IList<Enqueries> EnqueriesList { get; set; }
    }
}
