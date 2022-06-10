using AutoMapper;
using RestClient.Infra.Dtos;
using RestClient.Orm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.ORM.Mapping
{
    public class DataModelColumnMapper : 
        BaseMapper<DataModelColumn, DataModelColumnDto>, 
        IBaseMapper<DataModelColumn, DataModelColumnDto>
    {
        public DataModelColumnMapper(IMapper mapper) : base(mapper)
        {

        }

        public override DataModelColumn ToModel(DataModelColumnDto dto)
        {
            return new DataModelColumn
            {
                Id = dto.Id,
                DataModelId = dto.DataModel.Id,
                DataTypeId = dto.DataType.Id,
                Name = dto.Name,
                NormalizedName = dto.NormalizedName,
                Default = dto.Default,
                Required = dto.Required,
                Unique = dto.Unique
            };
        }
    }
}
