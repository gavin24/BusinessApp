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
    public class ImagesRestService : IImagesRestService
    {
        private readonly IImagesRestRepository _imagesRestRepository;
        public ImagesRestService(IImagesRestRepository imagesRestRepository)
        {
            _imagesRestRepository = imagesRestRepository;

        }
        public Task Delete(long id)
        {
            return _imagesRestRepository.Delete(id, "http://xamBusinessApp.azure.com/images/delete/");
        }

        public Task<Images> Get(long id)
        {
            return _imagesRestRepository.Get(id, "http://xamBusinessApp.azure.com/images/get/");
        }

        public Task<IList<Images>> GetAllRecords()
        {
            return _imagesRestRepository.FindAll("", "http://xamBusinessApp.azure.com/images/all/");
        }

        public Task<Images> GetImageByClientId(long clientId)
        {
            return _imagesRestRepository.Get(clientId, "http://xamBusinessApp.azure.com/images/allbyclientid");
        }

        public Task<Images> GetImageByProductId(long productId)
        {
            return _imagesRestRepository.Get(productId, "http://xamBusinessApp.azure.com/images/allbyproductid");
        }

        public Task<Images> GetImageByUserId(long userId)
        {
            return _imagesRestRepository.Get(userId, "http://xamBusinessApp.azure.com/images/allbyuserid");
        }

        public Task<long> Save(Images images)
        {
            return _imagesRestRepository.Save(images, "http://xamBusinessApp.azure.com/images");
        }

        public Task SaveOrUpdate(Images images, long id)
        {
            return _imagesRestRepository.SaveOrUpdate(id, images, "http://xamBusinessApp.azure.com/images/update/");
        }
    }
}
