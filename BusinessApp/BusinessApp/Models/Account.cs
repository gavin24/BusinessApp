using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Enums;
using SQLite.Net;
using SQLite.Net.Attributes;

namespace BusinessApp.Models
{
   public class Account:Model
   {
        [PrimaryKey, AutoIncrement]
        private long Id { get; set; }
       private long ClientId { get; set; }
       private string AccountName { get; set; }
   //    private IList<Orders> OrdersList { get; set; }
     //  private IList<Enqueries> EnqueriesList { get; set; }


   }
}
