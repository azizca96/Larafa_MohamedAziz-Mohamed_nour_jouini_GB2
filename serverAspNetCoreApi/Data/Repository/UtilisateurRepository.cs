using serverAspNetCoreApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Repository
{
    public class UtilisateurRepository : Repository<Utilisateur>
    {
        public UtilisateurRepository(DbContext context) : base(context)
        {
        }

        /*public Utilisateur FindUtilisateurByNom(string nom)
        {
            using (var dbContext = new GestionSyndicatDbContext())
            {
                var utilisateurRepository = new UtilisateurDAO(dbContext);
                return utilisateurRepository.FindByNom(nom);
            }
        }*/

    }
}