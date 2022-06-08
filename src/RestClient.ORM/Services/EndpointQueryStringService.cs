using RestClient.Infra.Dtos;
using RestClient.Orm.Models;
using RestClient.ORM.Mapping;
using RestClient.ORM.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.ORM.Services
{
    public class EndpointQueryStringService : BaseService<EndpointQueryString, EndpointQueryStringDto>
    {
        public EndpointQueryStringService(EndpointQueryStringRepository repos, EndpointQueryStringMapper mapper) : base(repos, mapper)
        {

        }
    }
}
