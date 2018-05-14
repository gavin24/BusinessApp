using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface ICategoriesRestService
    {
        Task Delete(long id);
        Task SaveOrUpdate(Categories cat,long id);
        Task<long> Save(Categories cat);
        Task<IList<Categories>> GetAllRecords();
        Task<Categories> Get(long id);
    }
}
