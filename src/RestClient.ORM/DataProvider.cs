using RestClient.ORM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Orm
{
    public class DataProvider
    {
        public DataProvider(
            ApiService apiService, 
            DataModelColumnService dataModelColumnService, 
            DataModelService dataModelService,
            DataTypeService dataTypeService,
            EndpointHeaderArgumentService endpointHeaderArgumentService,
            EndpointQueryStringService endpointQueryStringService,
            EndpointService endpointService,
            HistoryService historyService)
        {
            ApiService = apiService;
            DataModelColumnService = dataModelColumnService;
            DataModelService = dataModelService;
            DataTypeService = dataTypeService;
            EndpointHeaderArgumentService = endpointHeaderArgumentService;
            EndpointQueryStringService = endpointQueryStringService;
            EndpointService = endpointService;
            HistoryService = historyService;
        }

        public ApiService ApiService { get; set; }
        public DataModelColumnService DataModelColumnService { get; set; }
        public DataModelService DataModelService { get; set; }
        public DataTypeService DataTypeService { get; set; }
        public EndpointHeaderArgumentService EndpointHeaderArgumentService { get; set; }
        public EndpointQueryStringService EndpointQueryStringService { get; set; }
        public EndpointService EndpointService { get; set; }
        public HistoryService HistoryService { get; set; }
    }
}
