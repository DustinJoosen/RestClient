using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Infra.Dtos
{
    public class EndpointHeaderArgumentDto : IIdentifiable
    {
        public Guid Id { get; set; }
        public EndpointDto Endpoint { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Required { get; set; }
    }
}
