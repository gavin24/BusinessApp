using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using BusinessApp.Enums;
namespace BusinessApp.Models
{
   public class CategoriesEntity
    {
        private long Id { get; set; }
        private string CategoryName { get; set; }
        private List<Products> Products { get; set; }
    }
}
