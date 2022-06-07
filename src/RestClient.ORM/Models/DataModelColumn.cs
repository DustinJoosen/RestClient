using RestClient.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Orm.Models
{
    public class DataModelColumn : IIdentifiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public int DataModelId { get; set; }
        public DataModel DataModel { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(64)]
        public string NormalizedName { get; set; }
        
        [StringLength(256)]
        public string Default { get; set; }

        [Required]
        public int DataTypeId { get; set; }
        public DataType DataType { get; set; }

        public bool Required { get; set; } = true;
        public bool Unique { get; set; } = false;
    }
}
