using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace generic_api_1.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class Controller2 : ControllerBase
    {
        // GET api/values
        [HttpGet("Metodo3")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Hola mundo desde Metodo 3." };
        }

        // GET api/values/5
        [HttpGet("Metodo4/{id}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        [ProducesResponseType(200)]
        public ActionResult<string> Get(int id)
        {
            return "El ID es: "+id+" y corresponde al Metodo 4.";
        }

    }
}
