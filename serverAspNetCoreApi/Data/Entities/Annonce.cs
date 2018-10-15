using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Entities
{
    public class Annonce : BaseEntity
    {
        public Annonce()
        {

        }

        
        [Required]
        [StringLength(30)]
        public string Description { get; set; }

        public int PublicationId { get; set; }
        [ForeignKey(nameof(PublicationId))]
        public virtual Publication Publication { get; set; }

    }
}