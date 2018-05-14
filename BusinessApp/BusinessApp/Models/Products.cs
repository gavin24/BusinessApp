using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLite.Net.Attributes;

namespace BusinessApp.Models
{
    public class Products : Model
    {
        [PrimaryKey, AutoIncrement]
        private long Id { get; set; }
        private string Name { get; set; }
        private double PriceAmount { get; set; }
        private long CatergoryId { get; set; }
        private string Description { get; set; }
        private int Quantity { get; set; }
        private long ProductImageId { get; set; }
    }
}
