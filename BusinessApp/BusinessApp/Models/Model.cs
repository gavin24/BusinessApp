using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace BusinessApp.Models
{
   public class Model
    {
        private long Id { get; set; }
       private DateTime CreatedAt { get; set; }
        private DateTime ModifiedAt { get; set; }
    }
}
