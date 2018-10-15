using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using serverAspNetCoreApi.Data;
using serverAspNetCoreApi.Data.Entities;

namespace serverAspNetCoreApi.Controllers
{
    [Route("api/heroes")]
    public class HeroesController : Controller
    {
        private readonly AppDbContext _context;

        public HeroesController(AppDbContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Heroes.ToArray());

            /*
            return Ok(new Hero[]
            {
                new Hero { Id= 11, Name= "Mr. Nice" },
                new Hero { Id= 12, Name= "Narco" },
                new Hero { Id= 13, Name= "Bombasto" },
                new Hero { Id= 14, Name= "Celeritas" },
                new Hero { Id= 15, Name= "Magneta" },
                new Hero { Id= 16, Name= "RubberMan" },
                new Hero { Id= 17, Name= "Dynama" },
                new Hero { Id= 18, Name= "Dr IQ" },
                new Hero { Id= 19, Name= "Magma" },
                new Hero { Id= 20, Name= "Tornado" }

            });
            */
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return 
                Ok(_context
                .Heroes
                .SingleOrDefault(h => h.Id == id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Hero entity)
            //prendre de la partie body du http
        {
            _context.Heroes.Add(entity);
            _context.SaveChanges();
            return Ok(_context.Heroes.Last());
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody]Hero entity)
        {
            var toUpdate = _context
                           .Heroes
                           .SingleOrDefault(h => h.Id == entity.Id);

            toUpdate.Name = entity.Name;

            _context.SaveChanges();

            return Ok(toUpdate);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var toDelete = _context
                           .Heroes
                           .SingleOrDefault(h => h.Id == id);
            _context.Heroes.Remove(toDelete);
            _context.SaveChanges();

            return Ok();

        }
    }
}
