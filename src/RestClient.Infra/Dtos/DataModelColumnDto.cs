using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Infra.Dtos
{
    public class DataModelColumnDto : IIdentifiable
    {
        public Guid Id { get; set; }
        public DataModelDto DataModel { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string Default { get; set; }
        public DataTypeDto DataType { get; set; }
        public bool Required { get; set; }
        public bool Unique { get; set; }
    }
}
