using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Enums;
using SQLite;
using SQLite.Net.Attributes;

namespace BusinessApp.Models
{
    public class Notification : Model
    {
        [PrimaryKey, AutoIncrement]
        private long Id { get; set; }
        private NotficationType NotType { get; set; }
        private long UserId { get; set; }
        private string Header { get; set; }
        private string Body { get; set; }
        private DateTime TimeSent { get; set; }
        
    }
}
