using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using BusinessApp.Enums;
namespace BusinessApp.Models
{
   public class NotificationEntity
    {
        private long Id { get; set; }
        private NotficationType NotType { get; set; }
        private long UserId { get; set; }
        private string Header { get; set; }
        private string Body { get; set; }
        private DateTime TimeSent { get; set; }
    }
}
