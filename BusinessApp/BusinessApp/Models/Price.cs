using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLite.Net.Attributes;

namespace BusinessApp.Models
{
    public class Price : Model
    {
        [PrimaryKey, AutoIncrement]
        private long Id { get; set; }
        private string Currency { get; set; }
        private double Amount { get; set; }

    }
}
