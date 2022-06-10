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
    public class EndpointQueryStringMapper : 
        BaseMapper<EndpointQueryString, EndpointQueryStringDto>, 
        IBaseMapper<EndpointQueryString, EndpointQueryStringDto>
    {
        public EndpointQueryStringMapper(IMapper mapper) : base(mapper)
        {

        }

        public override EndpointQueryString ToModel(EndpointQueryStringDto dto)
        {
            return new EndpointQueryString
            {
                Id = dto.Id,
                Default = dto.Default,
                Key = dto.Key,
                Required = dto.Required,
                EndpointId = dto.Endpoint.Id
            };
        }
    }
}
