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
   public class EnqueriesEntity
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private string Notes { get; set; }
        private Images Pictures { get; set; }
        private DateTime EnquiryDate { get; set; }
    }
}
