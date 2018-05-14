using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLite.Net.Attributes;

namespace BusinessApp.Models
{
    public class Cart : Model
    {
        [PrimaryKey, AutoIncrement]
        private long Id { get; set; }
        private long ClientId { get; set; }
    //    private List<Products> productList { get; set; } 
        private DateTime CartCreated { get; set; }
        private int ItemAmount { get; set; }
        private double Total { get; set; }
    }
}
