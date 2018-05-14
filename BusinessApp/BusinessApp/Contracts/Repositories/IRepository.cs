using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Contracts.Repositories
{
   public interface IRepository<T>
   {
      
        T Get(long id);
        long Save(T entity);
        void SaveOrUpdate(T entity);
        void Delete(long id);
        IList<T> GetAllRecords(String query);
    }
}
