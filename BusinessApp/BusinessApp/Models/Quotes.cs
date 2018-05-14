using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLite.Net.Attributes;

namespace BusinessApp.Models
{
    public class Quotes : Model
    {
        [PrimaryKey, AutoIncrement]
        private long Id { get; set; }
        private long ClientId { get; set; }
        private string Body { get; set; }
     //   private IList<Products> ProductList { get; set; }
        private DateTime DateSent { get; set; }
        private long UserId { get; set; }
    }
    
}
