using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface IContactInfoRestService
    {
        Task<ContactInfo> GetContactInfoByClientId(long clientId);
        Task Delete(long id);
        Task SaveOrUpdate(ContactInfo contactInfo,long id);
        Task<long> Save(ContactInfo contactInfo);
        Task<IList<ContactInfo>> GetAllRecords();
        Task<ContactInfo> Get(long id);
    }
}
