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
   public class ImagesEntity
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private byte[] ImageBytes { get; set; }
        private string ImageName { get; set; }
        private string ImageExtension { get; set; }
    }
}
