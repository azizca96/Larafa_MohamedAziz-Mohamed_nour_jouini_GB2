using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Entities
{
    public class Utilisateur : BaseEntity
    {
        public Utilisateur()
        {
            Role = UtilisateurProfile.Prorietaire;
            this.Publications = new List<Publication>();
            this.Proprietes = new List<Propriete>();
            this.Notifications = new List<Notification>();
        }
        //type enumere
        public enum UtilisateurProfile
        {
            Admistrator = 1,
            Prorietaire = 2
        }

        [Required]
        [StringLength(30)]
        public string Nom { get; set; }

        //[Required]
        [StringLength(30)]
        public string Prenom { get; set; }

        //[Required]
        [StringLength(30)]
        public string Login { get; set; }

        //[Required]
        [StringLength(30)]
        public string MotPasse { get; set; }

        public string Email { get; set; }

        public string TelephoneFixe { get; set; }

        public string TelephonePortable { get; set; }

        [Required]
        public UtilisateurProfile Role { get; set; }

        [InverseProperty(nameof(Publication.Utilisateur))]
        List<Publication> Publications { get; set; }

        [InverseProperty(nameof(Propriete.Utilisateur))]
        List<Propriete> Proprietes { get; set; }

        [InverseProperty(nameof(Notification.Utilisateur))]
        List<Notification> Notifications { get; set; }

    }
}