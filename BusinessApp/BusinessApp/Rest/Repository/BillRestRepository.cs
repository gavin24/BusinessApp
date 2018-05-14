using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class BillRestRepository : BaseRestRepository<Bill>, IBillRestRepository
    {
        public List<Bill> GetBillsByClientId(long clientId)
        {
            throw new NotImplementedException();
        }
    }
}
