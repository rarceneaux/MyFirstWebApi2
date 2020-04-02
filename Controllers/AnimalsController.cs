using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApi.Models;

namespace MyFirstWebApi.Controllers
{
    [Route("api/animals")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        // GET /api/animals
  
           List<Animal> _animals = new List<Animal>
            {
                new Animal {Id = 1, Name = "Steve", Type = "Elephant", Weight = 2000},
                new Animal {Id = 2, Name = "George", Type = "Monkey", Weight = 87},
                new Animal {Id = 3, Name = "Tony", Type = "Tiger", Weight = 1200}
            };

     
    [HttpGet]
    public IActionResult GetAllAnimals()
        {
            return Ok(_animals);
        }

        // GET /api/animals/{id}
        [HttpGet("{id}")]
        public IActionResult GetSingleAnimal (int id)
        {
            var animalIWant = _animals.FirstOrDefault(a => a.Id == id);
            if(animalIWant == null)
            {
                return NotFound($"Animal with the id {id} was not found")
;           }
            return Ok(animalIWant);
        }

    }
}