using BusinessApp.Models;
using BusinessApp.Rest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Implementation
{
   public interface IImagesRestRepository : IBaseRestRepository<Images>
    {
        Images GetImageByProductId(long productId);
        Images GetImageByClientId(long clientId);
        Images GetImageByUserId(long userId);
    }
}
