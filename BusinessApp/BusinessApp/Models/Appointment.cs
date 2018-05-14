using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLite.Net.Attributes;

namespace BusinessApp.Models
{
    public class Appointment : Model
    {
        [PrimaryKey, AutoIncrement]
        private long Id { get; set; }
        private long ClientId { get; set; }
        private DateTime? AppointmentDate { get; set; }
        private string StartTime { get; set; }
        private string EndTime { get; set; }
        private long AppointmentUserId { get; set; }
        private string Notes { get; set; }
    }
}
