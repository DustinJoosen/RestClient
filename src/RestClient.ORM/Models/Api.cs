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
    public class Api : IIdentifiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }
        
        [Required]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Url)]
        public string Url { get; set; }


        public virtual ICollection<Endpoint> Endpoints { get; set; }

    }
}
