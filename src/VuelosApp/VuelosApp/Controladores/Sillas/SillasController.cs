using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VuelosApp.Sillas
{
    [Route("api/sillas")]
    [ApiController]
    public class SillasController : ControllerBase
    {
        // GET: api/Sillas
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Sillas/5
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sillas
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Sillas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
