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
   public class OrdersEntity
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private IList<OrderLine> OrderLineItems { get; set; }
        private long OrderNumber { get; set; }
        private DateTime OrderDate { get; set; }
        private OrderStatus OrderStat { get; set; }
    }
}
