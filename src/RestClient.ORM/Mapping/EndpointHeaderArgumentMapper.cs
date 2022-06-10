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
    public class EndpointHeaderArgumentMapper : 
        BaseMapper<EndpointHeaderArgument, EndpointHeaderArgumentDto>, 
        IBaseMapper<EndpointHeaderArgument, EndpointHeaderArgumentDto>
    {
        public EndpointHeaderArgumentMapper(IMapper mapper) : base(mapper)
        {

        }

        public override EndpointHeaderArgument ToModel(EndpointHeaderArgumentDto dto)
        {
            return new EndpointHeaderArgument
            {
                Id = dto.Id,
                Name = dto.Name,
                Value = dto.Value,
                Required = dto.Required,
                EndpointId = dto.Endpoint.Id
            };
        }
    }
}
