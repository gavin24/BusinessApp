using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class LocationRestRepository : BaseRestRepository<Location>, ILocationRestRepository
    {
        public LocationRestRepository()
        {

        }
        public Location GetLocationByCustomerId(long customerId)
        {
            throw new NotImplementedException();
        }
    }
}
