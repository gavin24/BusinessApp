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
   public class PriceEntity
    {
        private long Id { get; set; }
        private string Currency { get; set; }
        private double Amount { get; set; }
    }
}
