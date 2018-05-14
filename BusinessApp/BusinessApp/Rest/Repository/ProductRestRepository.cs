using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class ProductRestRepository : BaseRestRepository<Products>, IProductRestRepository
    {
        public ProductRestRepository()
        {

        }
        public List<Products> GetProductsByCategoryId(long categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
