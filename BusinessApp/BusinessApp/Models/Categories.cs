using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLite.Net.Attributes;

namespace BusinessApp.Models
{
    public class Categories : Model
    {
        [PrimaryKey, AutoIncrement]
        private long Id { get; set; }
        private string CategoryName { get; set; }
     //   private List<Products> Products { get; set; }
        
    }
}
