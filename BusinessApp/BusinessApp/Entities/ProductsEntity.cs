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
   public class ProductsEntity
    {
        private long Id { get; set; }
        private string Name { get; set; }
        private Price PriceAmout { get; set; }
        private long CatergoryId { get; set; }
        private string Description { get; set; }
        private int Quantity { get; set; }
        private Images ProductImage { get; set; }
    }
}
