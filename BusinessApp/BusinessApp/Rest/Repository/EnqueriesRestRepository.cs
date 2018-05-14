using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class EnqueriesRestRepository : BaseRestRepository<Enqueries>, IEnqueriesRestRepository
    {
        public EnqueriesRestRepository()
        {

        }
        public List<Enqueries> GetAllEnqueriesByClientId(long clientId)
        {
            throw new NotImplementedException();
        }
    }
}
