using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
   public interface IBaseRestRepository<T>
    {
        Task <T> Get(long id, string url);
        Task<long> Save(T itemToUpdate, string url);
        Task SaveOrUpdate(long itemIndex, T itemToUpdate, string url);
        Task  Delete(long id, string url);
        Task<IList<T>> FindAll(string query, string url);
        Task<IList<T>> FindAllById(long id, string url);
    }
}
