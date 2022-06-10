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
    public class History : IIdentifiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public Guid EndpointId { get; set; }
        public Endpoint Endpoint { get; set; }
        
        [Required]
        public DateTime SentAt { get; set; }
        
        [Required]
        public int StatusCode { get; set; }
        
        [Required]
        public string RequestMessage { get; set; }
        
        [Required]
        public string Content { get; set; }
    }
}
