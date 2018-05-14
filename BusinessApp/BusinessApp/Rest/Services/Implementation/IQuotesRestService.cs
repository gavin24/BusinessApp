using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface IQuotesRestService
    {
        Task<IList<Quotes>> GetQuotesByClientId(long clientId);
        Task<IList<Quotes>> GetQuotesByUserId(long userId);
        Task Delete(long id);
        Task SaveOrUpdate(Quotes quotes,long id);
        Task<long> Save(Quotes quotes);
        Task<IList<Quotes>> GetAllRecords();
        Task<Quotes> Get(long id);
    }
}
