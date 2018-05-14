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
   public class OrderLineEntity
    {
        private long Id { get; set; }
        private long OrderNumber { get; set; }
        private long ClientNumber { get; set; }
        private string ProductName { get; set; }
        private long ProductId { get; set; }
    }
}
