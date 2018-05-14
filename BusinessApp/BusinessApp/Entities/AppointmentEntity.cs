using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using BusinessApp.Enums;
namespace BusinessApp.entities
{
   public class AppointmentEntity
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private DateTime? AppointmentDate { get; set; }
        private string StartTime { get; set; }
        private string EndTime { get; set; }
        private User AppointmentUser { get; set; }
        private string Notes { get; set; }
    }
}
