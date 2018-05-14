using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface ICartRestService
    {
        Task<Cart> GetCartByClientId(long clientId);
        Task Delete(long id);
        Task SaveOrUpdate(Cart cart,long id);
        Task<long> Save(Cart cart);
        Task<IList<Cart>> GetAllRecords();
        Task<Cart> Get(long id);
    }
}
