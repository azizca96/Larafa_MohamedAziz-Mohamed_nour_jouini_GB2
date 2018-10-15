using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using serverAspNetCoreApi.Data;
using serverAspNetCoreApi.Data.Entities;
using static serverAspNetCoreApi.Data.Entities.Utilisateur;

namespace serverAspNetCoreApi.Controllers
{
    //Url de l'api prorietaire
    [Route("api/proprietaires")]
    public class ProprietaireController : Controller
    {
        private readonly AppDbContext _context;

        public ProprietaireController(AppDbContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Utilisateurs.ToArray());

        }
        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return
                Ok(_context
                .Utilisateurs
                .SingleOrDefault(h => h.Id == id && h.Role == UtilisateurProfile.Prorietaire));//on a ajouter une autre condition car on a deux role et ici on doit utiliser le role proprietaire
        }
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Utilisateur entity)
        //prendre de la partie body du http
        {
            _context.Utilisateurs.Add(entity);
            _context.SaveChanges();
            return Ok(_context.Utilisateurs.Last());
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody]Utilisateur entity)
        {
            var toUpdate = _context
                           .Utilisateurs
                           .SingleOrDefault(h => h.Id == entity.Id && h.Role == UtilisateurProfile.Prorietaire);

            toUpdate.Nom = entity.Nom;
            toUpdate.Prenom = entity.Prenom;
            toUpdate.Email = entity.Email;
            toUpdate.TelephoneFixe = entity.TelephoneFixe;
            toUpdate.TelephonePortable = entity.TelephonePortable;

            _context.SaveChanges();

            return Ok(toUpdate);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var toDelete = _context
                           .Utilisateurs
                           .SingleOrDefault(h => h.Id == id && h.Role == UtilisateurProfile.Prorietaire);
            _context.Utilisateurs.Remove(toDelete);
            _context.SaveChanges();

            return Ok();

        }

    }
}