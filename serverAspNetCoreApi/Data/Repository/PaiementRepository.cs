using serverAspNetCoreApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Repository
{
    public class PaiementRepository : Repository<Paiement>
    {
        public PaiementRepository(DbContext context) : base(context)
        {
        }

        /*public Paiement FindPaiementByDatePaiement(DateTime datePaiement)
        {
            using (var dbContext = new GestionSyndicatDbContext())
            {
                var paiementRepository = new PaiementDAO(dbContext);
                return paiementRepository.FindByDatePaiement(datePaiement);
            }
        }*/

    }
}