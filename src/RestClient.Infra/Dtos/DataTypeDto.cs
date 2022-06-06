using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Infra.Dtos
{
    public class DataTypeDto : IIdentifiable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Annotation { get; set; }
    }
}
