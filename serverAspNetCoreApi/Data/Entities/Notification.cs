using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Entities
{
    public class Notification : BaseEntity
    {
        public Notification()
        {
            this.Paiements = new List<Paiement>();
        }

        
        [Required]
        [StringLength(30)]
        public string Type { get; set; }

        public int UtilisateurId { get; set; }
        [ForeignKey(nameof(UtilisateurId))]
        public virtual Utilisateur Utilisateur { get; set; }

        [InverseProperty(nameof(Paiement.Notification))]
        List<Paiement> Paiements { get; set; }

    }
}