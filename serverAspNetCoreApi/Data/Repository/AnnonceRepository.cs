using serverAspNetCoreApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Repository
{
    public class AnnonceRepository : Repository<Annonce>
    {
        public AnnonceRepository(DbContext context) : base(context)
        {
        }

        /*public Annonce FindAnnonceByDescription(string description)
        {
            using (var dbContext = new GestionSyndicatDbContext())
            {
                var annonceRepository = new AnnonceDAO(dbContext);
                return annonceRepository.FindByDescription(description);
            }
        }*/
        
    }
}