using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class StockRestRepository : BaseRestRepository<Stock>, IStockRestRepository
    {
        public StockRestRepository()
        {

        }
        public Stock GetStockByProductId(long productId)
        {
            throw new NotImplementedException();
        }
    }
}
