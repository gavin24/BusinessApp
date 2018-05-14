using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLite.Net.Attributes;

namespace BusinessApp.Models
{
    public class Location : Model
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }
        public string CoOrdinates { get; set; }
        public long ClientId { get; set; }
        public string LocationName { get; set; }
    }
}