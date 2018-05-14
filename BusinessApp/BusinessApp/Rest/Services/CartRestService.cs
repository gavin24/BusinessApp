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
    public class CartRestService : ICartRestService
    {
        private readonly ICartRestRepository _cartRestRepository;
        public CartRestService(ICartRestRepository cartRestRepository)
        {
            _cartRestRepository = cartRestRepository;

        }
        public Task Delete(long id)
        {
            return _cartRestRepository.Delete(id, "http://xamBusinessApp.azure.com/carts/delete/");
        }

        public Task<Cart> Get(long id)
        {
            return _cartRestRepository.Get(id, "http://xamBusinessApp.azure.com/carts/get/");
        }

        public Task<IList<Cart>> GetAllRecords()
        {
            return _cartRestRepository.FindAll("", "http://xamBusinessApp.azure.com/carts/all/");
        }

        public Task<Cart> GetCartByClientId(long clientId)
        {
            return _cartRestRepository.Get(clientId, "http://xamBusinessApp.azure.com/carts/allbyclientid/");
        }

        public Task<long> Save(Cart cart)
        {
            return _cartRestRepository.Save(cart, "http://xamBusinessApp.azure.com/carts");
        }

        public Task SaveOrUpdate(Cart cart, long id)
        {
            return _cartRestRepository.SaveOrUpdate(id, cart, "http://xamBusinessApp.azure.com/carts/update/");
        }
    }
}
