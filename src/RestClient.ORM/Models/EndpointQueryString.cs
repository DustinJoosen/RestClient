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
    public class EndpointQueryString : IIdentifiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public int EndpointId { get; set; }
        public Endpoint Endpoint { get; set; }
        
        [Required]
        public string Key { get; set; }
        
        [Required]
        public string Default { get; set; }
        public bool Required { get; set; } = false;
    }
}
