using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Entities
{
    public class Propriete : BaseEntity
    {
        public Propriete()
        {

        }

        public enum ProprieteStatut
        {
            Admistrator = 1,
            Utilisateur = 2
        }

        [Required]
        [StringLength(30)]
        public string Description { get; set; }

        [Required]
        [StringLength(30)]
        public string Proprietes { get; set; }

        [Required]
        public ProprieteStatut Statut { get; set; }

        public int UtilisateurId { get; set; }
        [ForeignKey(nameof(UtilisateurId))]
        public virtual Utilisateur Utilisateur { get; set; }

    }
}