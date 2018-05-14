using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class AddressRestRepository : BaseRestRepository<Address>, IAddressRestRepository
    {

        public AddressRestRepository()
        {

        }
        
       
        public Address GetAddressByUserId(long userId)
        {
            throw new NotImplementedException();
        }
    }
}
