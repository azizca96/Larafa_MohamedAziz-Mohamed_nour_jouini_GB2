using Microsoft.EntityFrameworkCore;
using serverAspNetCoreApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }

        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Projet> Projets { get; set; }
        public DbSet<Participe> Participes { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Propriete> Proprietes { get; set; }
        public DbSet<Annonce> Annonces { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        public AppDbContext
            (DbContextOptions options) : base(options)
        {
        }



    }
}
