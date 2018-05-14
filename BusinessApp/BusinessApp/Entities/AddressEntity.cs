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
   public class AddressEntity
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private string Line1 { get; set; }
        private string Line2 { get; set; }
        private string Line3 { get; set; }
        private string Line4 { get; set; }
        private string Line5 { get; set; }
    }
}
