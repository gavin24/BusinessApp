using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface IStockRestService
    {
        Task<Stock> GetStockByProductId(long productId);
        Task Delete(long id);
        Task SaveOrUpdate(Stock stock,long id);
        Task<long> Save(Stock stock);
        Task<IList<Stock>> GetAllRecords();
        Task<Stock> Get(long id);
    }
}
