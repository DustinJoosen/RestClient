using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Infra.Dtos
{
    public class EndpointDto : IIdentifiable
    {
        public Guid Id { get; set; }
        public ApiDto Api { get; set; }
        public string Name { get; set; }
        public HttpMethod HttpMethod { get; set; }
        public DataModelDto InputModel { get; set; }
        public DataModelDto OutputModel { get; set; }
    }
}
