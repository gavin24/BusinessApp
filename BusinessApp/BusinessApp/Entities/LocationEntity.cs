using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using BusinessApp.Enums;
namespace BusinessApp.Entities
{
   public class LocationEntity
    {
        public long Id { get; set; }
        public string CoOrdinates { get; set; }
        public long ClientId { get; set; }
        public string LocationName { get; set; }
    }
}
