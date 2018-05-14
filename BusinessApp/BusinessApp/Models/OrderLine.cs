using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLite.Net.Attributes;

namespace BusinessApp.Models
{
    public class OrderLine : Model
    {
        [PrimaryKey, AutoIncrement]
        private long Id { get; set; }
        private long OrderNumber { get; set; }
        private long ClientNumber { get; set; }
        private string ProductName { get; set; }
        private long ProductId { get; set; }
    }
}
