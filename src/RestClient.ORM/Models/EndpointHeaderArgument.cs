using RestClient.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Orm.Models
{
    public class EndpointHeaderArgument : IIdentifiable
    {
        public Guid Id { get; set; }

        public int EndpointId { get; set; }
        public Endpoint Endpoint { get; set; }
        
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Required { get; set; }
    }
}
