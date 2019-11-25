using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using VuelosApp.DAL.UnitOfWork;
using VuelosApp.Entidades;

namespace VuelosApp.Vuelos
{
    [Route("api/vuelos")]
    [ApiController]
    public class VuelosController : ControllerBase
    {
        private IConfiguration configuration { get; }
        private UnitOfWork UnitOfWork { get; }
        public VuelosController(IConfiguration configuration)
        {
            UnitOfWork = new UnitOfWork(configuration);
        }

        // GET: api/Sillas
        [HttpGet]
        public IEnumerable<VueloEnt> Get()
        {
            return UnitOfWork.VueloEntRepository.Getall();
        }

        // GET: api/Sillas/5
        [HttpGet]
        public VueloEnt Get(int id)
        {
            return UnitOfWork.VueloEntRepository.FindById(id);
        }

        // POST: api/Sillas
        [HttpPost]
        public void Post()
        {
            UnitOfWork.VueloEntRepository.add(new VueloEnt { FechaVuelo = DateTime.Now });
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
            UnitOfWork.VueloEntRepository.Delete(id);
        }
    }
}