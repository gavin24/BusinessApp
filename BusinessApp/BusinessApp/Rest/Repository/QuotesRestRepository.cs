using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class QuotesRestRepository : BaseRestRepository<Quotes>, IQuotesRestRepository
    {
        public QuotesRestRepository()
        {

        }
        public List<Quotes> GetQuotesByClientId(long clientId)
        {
            throw new NotImplementedException();
        }

        public List<Quotes> GetQuotesByUserId(long userId)
        {
            throw new NotImplementedException();
        }
    }
}
