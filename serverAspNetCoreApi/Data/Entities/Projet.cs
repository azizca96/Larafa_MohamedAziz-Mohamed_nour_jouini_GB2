using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Entities
{
    public class Projet : BaseEntity
    {
        public Projet()
        {

        }

        [Required]
        [StringLength(30)]
        public string Libelle { get; set; }

        [Required]
        [StringLength(30)]
        public string Titre { get; set; }

        [Required]
        public DateTime DateDebut { get; set; }

        [Required]
        public DateTime DateFin { get; set; }

        [InverseProperty(nameof(Paiement.Projet))]
        List<Paiement> Paiements { get; set; }

    }
}