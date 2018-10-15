using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Entities
{
    public class Participe : BaseEntity
    {
        public Participe()
        {

        }

        public int UtilisateurId { get; set; }
        [ForeignKey(nameof(UtilisateurId))]
        public virtual Utilisateur Utilisateur { get; set; }

        public int ProjetId { get; set; }
        [ForeignKey(nameof(ProjetId))]
        public virtual Projet Projet { get; set; }

    }
}