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
    }
}
