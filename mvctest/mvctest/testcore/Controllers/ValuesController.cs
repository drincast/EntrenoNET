using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace testcore.Controllers
{
    [Route("api/values")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] string text)
        {
            try
            {
                CreatedAtRouteResult res = CreatedAtRoute("Get", new { id = 2 }, 2);
                return Ok(text);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }            
        }

        [HttpPost("/Crear")]
        public IActionResult Crear([FromBody] string text)
        {
            return CreatedAtRoute("Get", new { id = 2 }, text); ;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            var res = "id: " + id.ToString() + ", value: " + value;

            return Ok(res);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(String.Format("Se borro {0}", id));
        }
    }
}
