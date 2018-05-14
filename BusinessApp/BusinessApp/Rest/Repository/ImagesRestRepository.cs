using BusinessApp.Models;
using BusinessApp.Rest.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class ImagesRestRepository : BaseRestRepository<Images>, IImagesRestRepository
    {
        public ImagesRestRepository()
        {

        }
        public Images GetImageByClientId(long clientId)
        {
            throw new NotImplementedException();
        }

        public Images GetImageByProductId(long productId)
        {
            throw new NotImplementedException();
        }

        public Images GetImageByUserId(long userId)
        {
            throw new NotImplementedException();
        }
    }
}
