using serverAspNetCoreApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Repository
{
    public class ParticipeRepository : Repository<Participe>
    {
        public ParticipeRepository(DbContext context) : base(context)
        {
        }

    }
}