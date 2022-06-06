using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Infra.Dtos
{
    public class HistoryDto : IIdentifiable
    {
        public Guid Id { get; set; }
        public EndpointDto Endpoint { get; set; }
        public DateTime SentAt { get; set; }
        public int StatusCode { get; set; }
        public string RequestMessage { get; set; }
        public string Content { get; set; }
    }
}
