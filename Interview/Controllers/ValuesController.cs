using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace Interview.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        // Return in JSON Format the Person objects with an object under them that contains their pet object.
        // Create Unit Tests

        [HttpGet]
        public string Get()
        {
            var personsRaw = System.IO.File.ReadAllText(@"C:\dev\Interview\Interview\data\person.txt");
            var petsRaw = System.IO.File.ReadAllText(@"C:\dev\Interview\Interview\data\pet.txt");

            return personsRaw;
        }
        
        // Create a Search endpoint that takes in a part of a persons name and returns a person object their pet objects.
    }
}