using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Entities
{
    public class Publication : BaseEntity
    {
        public Publication()
        {
            this.Annonces = new List<Annonce>();
        }

        [Required]
        public DateTime DatePublication { get; set; }

        public int UtilisateurId { get; set; }
        [ForeignKey(nameof(UtilisateurId))]
        public virtual Utilisateur Utilisateur { get; set; }
 
        [InverseProperty(nameof(Annonce.Publication))]
        List<Annonce> Annonces { get; set; }

    }
}