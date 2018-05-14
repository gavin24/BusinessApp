using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class ContactInfoRestRepository : BaseRestRepository<ContactInfo>, IContactInfoRestRepository
    {
        public ContactInfoRestRepository()
        {

        }
        public ContactInfo GetContactInfoByClientId(long clientId)
        {
            throw new NotImplementedException();
        }
    }
}
