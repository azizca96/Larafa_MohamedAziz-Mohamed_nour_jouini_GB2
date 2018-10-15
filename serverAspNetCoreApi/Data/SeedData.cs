using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using serverAspNetCoreApi.Data.Entities;
using System;
using System.Linq;

namespace serverAspNetCoreApi.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
               serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                // Look for any movies.
                if (!context.Heroes.Any())
                {
                    context.Heroes.AddRange(
                    new Hero { Id = 11, Name = "Mr. Nice" },
                    new Hero { Id = 12, Name = "Narco" },
                    new Hero { Id = 13, Name = "Bombasto" },
                    new Hero { Id = 14, Name = "Celeritas" },
                    new Hero { Id = 15, Name = "Magneta" },
                    new Hero { Id = 16, Name = "RubberMan" },
                    new Hero { Id = 17, Name = "Dynama" },
                    new Hero { Id = 18, Name = "Dr IQ" },
                    new Hero { Id = 19, Name = "Magma" },
                    new Hero { Id = 20, Name = "Tornado" }
                    );
                }


                


                //Insertion des données pour la table prorietaire
                if (!context.Utilisateurs.Any())
                {
                    context.Utilisateurs.AddRange(
                        new Utilisateur { Id = 1, Nom = "Mr. Nice", Email = "prop01@email.com", Role=Utilisateur.UtilisateurProfile.Prorietaire },
                        new Utilisateur { Id = 2, Nom = "Narco", Email = "prop02@email.com", Role = Utilisateur.UtilisateurProfile.Prorietaire },
                        new Utilisateur { Id = 13, Nom = "Bombasto", Role = Utilisateur.UtilisateurProfile.Prorietaire },
                        new Utilisateur { Id = 14, Nom = "Celeritas", Role = Utilisateur.UtilisateurProfile.Prorietaire },
                        new Utilisateur { Id = 15, Nom = "Magneta", Role = Utilisateur.UtilisateurProfile.Prorietaire },
                        new Utilisateur { Id = 16, Nom = "RubberMan", Role = Utilisateur.UtilisateurProfile.Prorietaire },
                        new Utilisateur { Id = 17, Nom = "Dynama", Role = Utilisateur.UtilisateurProfile.Prorietaire },
                        new Utilisateur { Id = 18, Nom = "Dr IQ", Role = Utilisateur.UtilisateurProfile.Prorietaire },
                        new Utilisateur { Id = 19, Nom = "Magma", Role = Utilisateur.UtilisateurProfile.Prorietaire },
                        new Utilisateur { Id = 20, Nom = "Tornado", Role = Utilisateur.UtilisateurProfile.Prorietaire },
                        new Utilisateur { Id = 100, Nom = "Admin", Role = Utilisateur.UtilisateurProfile.Admistrator }
                        );
                }


                
                context.SaveChanges();
            }
        }
    }
}
