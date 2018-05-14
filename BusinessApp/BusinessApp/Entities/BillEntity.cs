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
   public class BillEntity
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private Orders OrderInfo { get; set; }
        private DateTime BillSent { get; set; }
        private double Total { get; set; }
    }
}
