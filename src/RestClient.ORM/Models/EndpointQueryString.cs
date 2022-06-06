using RestClient.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Orm.Models
{
    public class EndpointQueryString : IIdentifiable
    {
        public Guid Id { get; set; }

        public int EndpointId { get; set; }
        public Endpoint Endpoint { get; set; }
        
        public string Key { get; set; }
        public string Default { get; set; }
        public bool Required { get; set; }
    }
}
