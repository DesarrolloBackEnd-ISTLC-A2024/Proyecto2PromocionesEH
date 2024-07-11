using Microsoft.AspNetCore.Mvc;
using Proyecto2PromocinesEH.Comunes;
using Proyecto2PromocionesEH.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proyecto2PromocionesEH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromocionesController : ControllerBase
    {
        // GET: api/<PromocionesController>
        [HttpGet]
        public List<Promociones> Get()
        {
            return ConexionDB.GetPromociones();
        }

        // GET api/<PromocionesController>/5
        [HttpGet("{id}")]
        public Promociones Get(string codigo)
        {
            return ConexionDB.GetPromociones(codigo);
        }

        // POST api/<PromocionesController>
        [HttpPost]
        public void Post([FromBody] Promociones objProducto)
        {
            ConexionDB.PostPromociones(objProducto);
        }


        // PUT api/<PromocionesController>/5
        [HttpPut("{id}")]
        public void Put(string codigo, [FromBody] Promociones objProducto)
        {
            ConexionDB.PutPromociones(codigo, objProducto);
        }


        // DELETE api/<PromocionesController>/5
        [HttpDelete("{id}")]
        public void Delete(string codigo)
        {
            ConexionDB.DeletePromociones(codigo);
        }

    }
}
