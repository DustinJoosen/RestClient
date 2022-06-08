using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.ORM.Mapping
{
    public abstract class BaseMapper<TModel, TDto>
    {
        private IMapper _mapper;
        public BaseMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public virtual TDto ToDto(TModel model)
        {
            return _mapper.Map<TDto>(model);
        }

        public virtual List<TDto> ToDto(List<TModel> models)
        {
            return _mapper.Map<List<TDto>>(models);
        }

        public virtual TModel ToModel (TDto dto)
        {
            return _mapper.Map<TModel>(dto);
        }
    }
}
