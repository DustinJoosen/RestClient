using AutoMapper;
using RestClient.Orm.Models;
using RestClient.Infra.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.ORM.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Api, ApiDto>();
            CreateMap<ApiDto, Api>();
            
            CreateMap<DataModelColumn, DataModelColumnDto>();
            CreateMap<DataModelColumnDto, DataModelColumn>();
            
            CreateMap<DataModel, DataModelDto>();
            CreateMap<DataModelDto, DataModel>();

            CreateMap<DataType, DataTypeDto>();
            CreateMap<DataTypeDto, DataType>();

            CreateMap<Endpoint, EndpointDto>();
            CreateMap<EndpointDto, Endpoint>();

            CreateMap<EndpointQueryString, EndpointQueryStringDto>();
            CreateMap<EndpointQueryStringDto, EndpointQueryString>();

            CreateMap<EndpointHeaderArgument, EndpointHeaderArgumentDto>();
            CreateMap<EndpointHeaderArgumentDto, EndpointHeaderArgument>();

            CreateMap<History, HistoryDto>();
            CreateMap<HistoryDto, History>();
        }
    }
}
