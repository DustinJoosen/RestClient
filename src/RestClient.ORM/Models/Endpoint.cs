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
    public class Endpoint : IIdentifiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public Guid ApiId { get; set; }
        public Api Api { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }
        public Infra.Enums.HttpMethod HttpMethod { get; set; } = Infra.Enums.HttpMethod.GET;

        public Guid InputModelId { get; set; }
        public DataModel InputModel { get; set; }

        public Guid OutputModelId { get; set; }
        public DataModel OutputModel { get; set; }

        [NotMapped]
        public virtual ICollection<EndpointHeaderArgument> EndpointHeaderArguments { get; set; }
        
        [NotMapped]
        public virtual ICollection<EndpointQueryString> EndpointQueryStrings { get; set; }
        
        [NotMapped]
        public virtual ICollection<History> Histories { get; set; }
    }
}
