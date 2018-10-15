using serverAspNetCoreApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Repository
{
    public class ProprieteRepository : Repository<Propriete>
    {
        public ProprieteRepository(DbContext context) : base(context)
        {
        }

        /*public Propriete FindProprieteByDescription(string description)
        {
            using (var dbContext = new GestionSyndicatDbContext())
            {
                var proprieteRepository = new ProprieteDAO(dbContext);
                return proprieteRepository.FindByDescription(description);
            }
        }*/

    }
}