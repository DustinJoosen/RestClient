using RestClient.ORM.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.ORM.Services
{
    public abstract class BaseService<TModel, TDto> : IBaseService<TDto>
    {
        private IBaseRepository<TModel> _repos;

        public BaseService(IBaseRepository<TModel> repos)
        {
            _repos = repos;
        }

        public virtual async Task<List<TDto>> GetAll()
        {
            return await _repos.GetAll();
        }

        public virtual async Task<TDto> GetById(Guid id)
        {
            return await _repos.GetById(id);
        }

        public virtual async Task<TDto> Create(TDto model)
        {
            return await _repos.Create(model);
        }

        public virtual async Task<TDto> Update(Guid id, TDto model)
        {
            return await _repos.Update(id, model);
        }

        public virtual async Task<TDto> Delete(Guid id)
        {
            return await _repos.Delete(id);
        }

        public virtual async Task<TDto> Delete(TDto model)
        {
            return await _repos.Delete(model);
        }
    }
}
