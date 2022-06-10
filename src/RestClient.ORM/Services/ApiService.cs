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
    public class ApiService : BaseService<Api, ApiDto>
    {
        public ApiService(ApiRepository repos, ApiMapper mapper) : base(repos, mapper)
        {

        }
    }
}
