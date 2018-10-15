using serverAspNetCoreApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Repository
{
    public class PublicationRepository : Repository<Publication>
    {
        public PublicationRepository(DbContext context) : base(context)
        {
        }

        /*public Publication FindPublicationByDescription(DateTime datePublication)
        {
            using (var dbContext = new GestionSyndicatDbContext())
            {
                var publicationRepository = new PublicationDAO(dbContext);
                return publicationRepository.FindByDatePublication(datePublication);
            }
        }*/

    }
}