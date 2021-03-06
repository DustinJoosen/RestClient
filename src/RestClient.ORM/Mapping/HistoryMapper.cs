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
    public class HistoryMapper : BaseMapper<History, HistoryDto>, IBaseMapper<History, HistoryDto>
    {
        public HistoryMapper(IMapper mapper) : base(mapper)
        {

        }

        public override History ToModel(HistoryDto dto)
        {
            return new History
            {
                Id = dto.Id,
                Content = dto.Content,
                EndpointId = dto.Endpoint.Id,
                RequestMessage = dto.RequestMessage,
                SentAt = dto.SentAt,
                StatusCode = dto.StatusCode,
            };
        }
    }
}
