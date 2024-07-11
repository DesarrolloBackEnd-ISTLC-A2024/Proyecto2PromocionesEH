using Microsoft.AspNetCore.Mvc;
using Proyecto2PromocinesEH.Comunes;
using Proyecto2PromocionesEH.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proyecto2PromocionesEH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        // GET: api/<ClientesController>
        [HttpGet]
        public List<Cliente> Get()
        {
            return ConexionDB.GetClientes();
        }

        // GET api/<ClientesController>/5
        [HttpGet("{cedula}")]
        public Cliente Get(string cedula)
        {
            return ConexionDB.GetCliente(cedula);
        }

        // POST api/<ClientesController>
        [HttpPost]
        public void Post([FromBody] Cliente objCliente)
        {
            ConexionDB.PostCliente(objCliente);
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{cedula}")]
        public void Put(string cedula, [FromBody] Cliente objCliente)
        {
            ConexionDB.PutCliente(cedula, objCliente);
        }


        // DELETE api/<ClientesController>/5
        [HttpDelete("{cedula}")]
        public void DeleteCliente(string cedula)
        {
            ConexionDB.DeleteCliente(cedula);
        }
    }
}

