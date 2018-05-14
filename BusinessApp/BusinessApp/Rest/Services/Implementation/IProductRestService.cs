using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
    public interface IProductRestService
    {
        Task<IList<Products>> GetProductsByCategoryId(long categoryId);
        Task Delete(long id);
        Task SaveOrUpdate(Products products,long id);
        Task<long> Save(Products products);
        Task<IList<Products>> GetAllRecords();
        Task<Products> Get(long id);
    }
}
