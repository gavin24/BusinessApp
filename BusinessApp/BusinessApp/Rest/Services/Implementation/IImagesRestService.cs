using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Services.Implementation
{
   public interface IImagesRestService
    {
        Task<Images> GetImageByProductId(long productId);
        Task<Images> GetImageByClientId(long clientId);
        Task<Images> GetImageByUserId(long userId);
        Task Delete(long id);
        Task SaveOrUpdate(Images images,long id);
        Task<long> Save(Images images);
        Task<IList<Images>> GetAllRecords();
        Task<Images> Get(long id);
    }
}
