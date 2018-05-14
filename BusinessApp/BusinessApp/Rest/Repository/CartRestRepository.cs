using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class CartRestRepository : BaseRestRepository<Cart>, ICartRestRepository
    {
        public CartRestRepository()
        {

        }
        public Cart GetCartByClientId(long clientId)
        {
            throw new NotImplementedException();
        }
    }
}
