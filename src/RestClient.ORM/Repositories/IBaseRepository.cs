using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.ORM.Repositories
{
    public interface IBaseRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task<T> Create(T model);
        Task<T> Update(Guid id, T model);
        Task<T> Delete(Guid id);
        Task<T> Delete(T model);
    }
}
