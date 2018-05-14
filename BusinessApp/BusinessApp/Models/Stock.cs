using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLite.Net.Attributes;

namespace BusinessApp.Models
{
    public class Stock : Model
    {
        [PrimaryKey, AutoIncrement]
        private long Id { get; set; }
        private long ProductId { get; set; }
        private int Amount { get; set; }
        private DateTime DateAccepted { get; set; }
        private string Supplier { get; set; }
    }
}
