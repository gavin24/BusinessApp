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
    public class BillRestService : IBillRestService
    {
        private readonly IBillRestRepository _billRestRepository;
        public BillRestService(IBillRestRepository billRestRepository)
        {
            _billRestRepository = billRestRepository;

        }
        public Task Delete(long id)
        {
            return _billRestRepository.Delete(id, "http://xamBusinessApp.azure.com/bills/delete/");
        }

        public Task<Bill> Get(long id)
        {
            return _billRestRepository.Get(id, "http://xamBusinessApp.azure.com/bills/get/");
        }

        public Task<IList<Bill>> GetAllRecords()
        {
            return _billRestRepository.FindAll("", "http://xamBusinessApp.azure.com/bills/all/");
        }

        public Task<IList<Bill>> GetBillsByClientId(long clientId)
        {
            return _billRestRepository.FindAllById(clientId, "http://xamBusinessApp.azure.com/bills/allbyclientid/");
        }

        public Task<long> Save(Bill bill)
        {
            return _billRestRepository.Save(bill, "http://xamBusinessApp.azure.com/bills");
        }

        public Task SaveOrUpdate(Bill bill, long id)
        {
            return _billRestRepository.SaveOrUpdate(id, bill, "http://xamBusinessApp.azure.com/bills/update/");
        }
    }
}
