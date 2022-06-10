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
    public class EndpointMapper : BaseMapper<Endpoint, EndpointDto>, IBaseMapper<Endpoint, EndpointDto>
    {
        public EndpointMapper(IMapper mapper) : base(mapper)
        {

        }

        public override Endpoint ToModel(EndpointDto dto)
        {
            return new Endpoint
            {
                Id = dto.Id,
                Name = dto.Name,
                ApiId = dto.Api.Id,
                HttpMethod = dto.HttpMethod,
                InputModelId = dto.InputModel.Id,
                OutputModelId = dto.OutputModel.Id
            };
        }
    }
}
