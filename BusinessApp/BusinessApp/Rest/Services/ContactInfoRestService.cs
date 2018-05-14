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
    public class ContactInfoRestService : IContactInfoRestService
    {
        private readonly IContactInfoRestRepository _contactInfoRestRepository;
        public ContactInfoRestService(IContactInfoRestRepository contactInfoRestRepository)
        {
            _contactInfoRestRepository = contactInfoRestRepository;

        }
        public Task Delete(long id)
        {
            return _contactInfoRestRepository.Delete(id, "http://xamBusinessApp.azure.com/contactinfo/delete/");
        }

        public Task<ContactInfo> Get(long id)
        {
            return _contactInfoRestRepository.Get(id, "http://xamBusinessApp.azure.com/contactinfo/get/");
        }

        public Task<IList<ContactInfo>> GetAllRecords()
        {
            return _contactInfoRestRepository.FindAll("", "http://xamBusinessApp.azure.com/contactinfo/all/");
        }

        public Task<ContactInfo> GetContactInfoByClientId(long clientId)
        {
            return _contactInfoRestRepository.Get(clientId, "http://xamBusinessApp.azure.com/contactinfo/allbyclientid/");
        }

        public Task<long> Save(ContactInfo contactInfo)
        {
            return _contactInfoRestRepository.Save(contactInfo, "http://xamBusinessApp.azure.com/contactinfo");
        }

        public Task SaveOrUpdate(ContactInfo contactInfo, long id)
        {
            return _contactInfoRestRepository.SaveOrUpdate(id, contactInfo, "http://xamBusinessApp.azure.com/contactinfo/update/");
        }
    }
}
