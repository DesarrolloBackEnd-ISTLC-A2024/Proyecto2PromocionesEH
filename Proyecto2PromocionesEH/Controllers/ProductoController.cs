using Microsoft.AspNetCore.Mvc;
using Proyecto2PromocinesEH.Comunes;
using Proyecto2PromocionesEH.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proyecto2PromocionesEH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        // GET: api/<ProductosController>
        [HttpGet]
        public List<Producto> Get()
        {
            return ConexionDB.GetProductos();
        }

        // GET api/<ProductosController>/5
        [HttpGet("{codigo}")]
        public Producto Get(string codigo)
        {
            return ConexionDB.GetProducto(codigo);
        }

        // POST api/<ProductosController>
        [HttpPost]
        public void Post([FromBody] Producto objProducto)
        {
            ConexionDB.PostProducto(objProducto);
        }

        // PUT api/<ProductosController>/5
        [HttpPut("{codigo}")]
        public void Put(string codigo, [FromBody] Producto objProducto)
        {
            ConexionDB.PutProducto(codigo, objProducto);
        }

        // DELETE api/<ProductosController>/5
        [HttpDelete("{codigo}")]
        public void Delete(string codigo)
        {
            ConexionDB.DeleteProducto(codigo);
        }
    }
}
