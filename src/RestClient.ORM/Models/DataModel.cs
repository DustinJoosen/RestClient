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
    public class DataModel : IIdentifiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }


        [NotMapped]
        public virtual ICollection<DataModelColumn> DataModelColumns { get; set; }
        [NotMapped]
        public virtual ICollection<Endpoint> Endpoints { get; set; }
    }
}
