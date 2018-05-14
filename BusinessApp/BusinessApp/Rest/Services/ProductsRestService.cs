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
    public class ProductsRestService : IProductRestService
    {
        private readonly IProductRestRepository _productsRestRepository;
        public ProductsRestService(IProductRestRepository productsRestRepository)
        {
            _productsRestRepository = productsRestRepository;

        }
        public Task Delete(long id)
        {
            return _productsRestRepository.Delete(id, "http://xamBusinessApp.azure.com/products/delete/");
        }

        public Task<Products> Get(long id)
        {
            return _productsRestRepository.Get(id, "http://xamBusinessApp.azure.com/products/get/");
        }

        public Task<IList<Products>> GetAllRecords()
        {
            return _productsRestRepository.FindAll("", "http://xamBusinessApp.azure.com/products/all/");
        }

        public Task<IList<Products>> GetProductsByCategoryId(long categoryId)
        {
            return _productsRestRepository.FindAllById(categoryId, "http://xamBusinessApp.azure.com/products/allbycatid/");
        }

        public Task<long> Save(Products products)
        {
            return _productsRestRepository.Save(products, "http://xamBusinessApp.azure.com/products");
        }

        public Task SaveOrUpdate(Products products, long id)
        {
            return _productsRestRepository.SaveOrUpdate(id, products, "http://xamBusinessApp.azure.com/products/update/");
        }
    }
}
