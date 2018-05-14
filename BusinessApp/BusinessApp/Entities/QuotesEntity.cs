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
   public class QuotesEntity
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private string Body { get; set; }
        private IList<Products> ProductList { get; set; }
        private DateTime DateSent { get; set; }
        private long UserId { get; set; }
    }
}
