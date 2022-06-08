using RestClient.ORM.Mapping;
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
        private IBaseMapper<TModel, TDto> _mapper;

        public BaseService(IBaseRepository<TModel> repos, IBaseMapper<TModel, TDto> mapper)
        {
            _repos = repos;
            _mapper = mapper;
        }

        public virtual async Task<List<TDto>> GetAll()
        {
            var models = await _repos.GetAll();
            return _mapper.ToDto(models);
        }

        public virtual async Task<TDto> GetById(Guid id)
        {
            var model = await _repos.GetById(id);
            return _mapper.ToDto(model);
        }

        public virtual async Task<TDto> Create(TDto dto)
        {
            var model = _mapper.ToModel(dto);
            await _repos.Create(model);

            return _mapper.ToDto(model);
        }

        public virtual async Task<TDto> Update(Guid id, TDto dto)
        {
            var model = _mapper.ToModel(dto);
            await _repos.Update(id, model);

            return _mapper.ToDto(model);
        }

        public virtual async Task<TDto> Delete(Guid id)
        {
            return _mapper.ToDto(await _repos.Delete(id));
        }

        //public virtual async Task<TDto> Delete(TDto dto)
        //{
        //    var model = _mapper.ToModel(dto);
        //    return _mapper.ToDto(await _repos.Delete(model));
        //}
    }
}
