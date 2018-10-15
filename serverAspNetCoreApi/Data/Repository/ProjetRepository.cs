using serverAspNetCoreApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Repository
{
    public class ProjetRepository : Repository<Projet>
    {
        public ProjetRepository(DbContext context) : base(context)
        {
        }

        /*public Projet FindProjetByLibelle(string libelle)
        {
            using (var dbContext = new GestionSyndicatDbContext())
            {
                var projetRepository = new ProjetDAO(dbContext);
                return projetRepository.FindByLibelle(libelle);
            }
        }*/

    }
}