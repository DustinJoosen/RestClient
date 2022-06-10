using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.ORM.Mapping
{
    public interface IBaseMapper<TModel, TDto>
    {
        TDto ToDto(TModel model);
        List<TDto> ToDto(List<TModel> model);
        TModel ToModel(TDto dto);

    }
}
