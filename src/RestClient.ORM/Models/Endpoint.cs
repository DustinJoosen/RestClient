using RestClient.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Orm.Models
{
    public class Endpoint : IIdentifiable
    {
        public Guid Id { get; set; }

        public int ApiId { get; set; }
        public Api Api { get; set; }

        public string Name { get; set; }
        public HttpMethod HttpMethod { get; set; }

        public int InputModelId { get; set; }
        public DataModel InputModel { get; set; }

        public int OutputModelId { get; set; }
        public DataModel OutputModel { get; set; }
    }
}
