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
   public class StockEntity
    {
        private long Id { get; set; }
        private long ProductId { get; set; }
        private int Amount { get; set; }
        private DateTime DateAccepted { get; set; }
        private string Supplier { get; set; }
    }
}
