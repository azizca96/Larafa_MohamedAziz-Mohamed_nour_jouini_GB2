using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Entities
{
    public class Budget : BaseEntity
    {
        public Budget()
        {

        }

        
        [Required]
        public double Totale { get; set; }

        [Required]
        public double Dette { get; set; }

        [InverseProperty(nameof(Paiement.Budget))]
        List<Paiement> Paiements { get; set; }

    }
}