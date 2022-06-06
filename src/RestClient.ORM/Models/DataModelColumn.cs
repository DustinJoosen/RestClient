using RestClient.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Orm.Models
{
    public class DataModelColumn : IIdentifiable
    {
        public Guid Id { get; set; }

        public int DataModelId { get; set; }
        public DataModel DataModel { get; set; }

        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string Default { get; set; }

        public int DataTypeId { get; set; }
        public DataType DataType { get; set; }
        
        public bool Required { get; set; }
        public bool Unique { get; set; }
    }
}
