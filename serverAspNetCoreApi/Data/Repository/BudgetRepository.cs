using serverAspNetCoreApi.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using serverAspNetCoreApi.Data.Entities;

namespace serverAspNetCoreApi.Data.Repository
{
    public class BudgetRepository : Repository<Budget>
    {
        public BudgetRepository(DbContext context) : base(context)
        {
        }

        /*public Budget FindBudgetByTotale(double totale)
        {
            using (var dbContext = new GestionSyndicatDbContext())
            {
                var budgetRepository = new BudgetDAO(dbContext);
                return budgetRepository.FindByTotale(totale);
            }
        }*/

    }
}