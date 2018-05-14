using BusinessApp.Rest.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;
using BusinessApp.Rest.Implementation;

namespace BusinessApp.Rest.Services
{
    public class StockRestService : IStockRestService
    {
        private readonly IStockRestRepository _stockRestRepository;
        public StockRestService(IStockRestRepository stockRestRepository)
        {
            _stockRestRepository = stockRestRepository;

        }
        public Task Delete(long id)
        {
            return _stockRestRepository.Delete(id, "http://xamBusinessApp.azure.com/stock/delete/");
        }

        public Task<Stock> Get(long id)
        {
            return _stockRestRepository.Get(id, "http://xamBusinessApp.azure.com/stock/get/");
        }

        public Task<IList<Stock>> GetAllRecords()
        {
            return _stockRestRepository.FindAll("", "http://xamBusinessApp.azure.com/stock/all/");
        }

        public Task<Stock> GetStockByProductId(long productId)
        {
            return _stockRestRepository.Get(productId, "http://xamBusinessApp.azure.com/stock/allbyproductid/");
        }

        public Task<long> Save(Stock stock)
        {
            return _stockRestRepository.Save(stock, "http://xamBusinessApp.azure.com/stock");
        }

        public Task SaveOrUpdate(Stock stock, long id)
        {
            return _stockRestRepository.SaveOrUpdate(id, stock, "http://xamBusinessApp.azure.com/stock/update/");
        }
    }
}
