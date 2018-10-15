using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Entities
{
    public class Paiement : BaseEntity
    {
        public Paiement()
        {

        }

        [Required]
        public double Montant { get; set; }

        [Required]
        public DateTime DatePaiement { get; set; }

        public int ProjetId { get; set; }
        [ForeignKey(nameof(ProjetId))]
        public virtual Projet Projet { get; set; }

        public int BudgetId { get; set; }
        [ForeignKey(nameof(BudgetId))]
        public virtual Budget Budget { get; set; }

        public int NotificationId { get; set; }
        [ForeignKey(nameof(NotificationId))]
        public virtual Notification Notification { get; set; }

    }
}