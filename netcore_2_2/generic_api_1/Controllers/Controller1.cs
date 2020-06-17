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
    public class Controller1 : ControllerBase
    {
        // GET api/values
        [HttpGet("Metodo1")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Hola mundo desde Metodo 1." };
        }

        // GET api/values/5
        [HttpGet("Metodo2/{id}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        [ProducesResponseType(200)]
        public ActionResult<string> Get(int id)
        {
            return "El ID enviado es: "+id+" y corresponde al Metodo 2.";
        }

    }
}
