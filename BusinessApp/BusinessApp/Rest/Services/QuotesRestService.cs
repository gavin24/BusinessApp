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
    public class QuotesRestService : IQuotesRestService
    {
        private readonly IQuotesRestRepository _quotesRestRepository;
        public QuotesRestService(IQuotesRestRepository quotesRestRepository)
        {
            _quotesRestRepository = quotesRestRepository;

        }
        public Task Delete(long id)
        {
            return _quotesRestRepository.Delete(id, "http://xamBusinessApp.azure.com/quotes/delete/");
        }

        public Task<Quotes> Get(long id)
        {
            return _quotesRestRepository.Get(id, "http://xamBusinessApp.azure.com/quotes/get/");
        }

        public Task<IList<Quotes>> GetAllRecords()
        {
            return _quotesRestRepository.FindAll("", "http://xamBusinessApp.azure.com/quotes/all/");
        }

        public Task<IList<Quotes>> GetQuotesByClientId(long clientId)
        {
            return _quotesRestRepository.FindAllById(clientId, "http://xamBusinessApp.azure.com/quotes/allbyclientid/");
        }

        public Task<IList<Quotes>> GetQuotesByUserId(long userId)
        {
            return _quotesRestRepository.FindAllById(userId, "http://xamBusinessApp.azure.com/quotes/allbyuserid/");
        }

        public Task<long> Save(Quotes quotes)
        {
            return _quotesRestRepository.Save(quotes, "http://xamBusinessApp.azure.com/quotes");
        }

        public Task SaveOrUpdate(Quotes quotes, long id)
        {
            return _quotesRestRepository.SaveOrUpdate(id, quotes, "http://xamBusinessApp.azure.com/quotes/update/");
        }
    }
}
