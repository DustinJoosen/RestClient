using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Infra.Dtos
{
    public class EndpointQueryStringDto : IIdentifiable
    {
        public Guid Id { get; set; }
        public EndpointDto Endpoint { get; set; }
        public string Key { get; set; }
        public string Default { get; set; }
        public bool Required { get; set; }
    }
}
