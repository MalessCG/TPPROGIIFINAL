using AutomotrizBack.Entidades;
using AutomotrizBack.Fachada.Implementacion;
using AutomotrizBack.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutomotrizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        // GET: api/<FacturaController>
        private IAplicacion servicio;
        public FacturaController()
        {
            servicio = new Aplicacion();
        }
        [HttpGet("clientes")]
        public IActionResult GetClientes()
        {
            return Ok(servicio.GetClientes());
        }

        // GET api/<FacturaController>/5
        [HttpGet("autopartes")]
        public IActionResult Get()
        {
            return Ok(servicio.GetAutopartes());
        }
        [HttpGet("facturas")]
        public IActionResult GetFacturas(DateTime desde, DateTime hasta, int cliente )
        {
            List<Factura> lst = null;
            try
            {
                lst = servicio.GetFacturas(desde, hasta, cliente);
                return Ok(lst);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        // POST api/<FacturaController>
        [HttpPost]
        public IActionResult Post([FromBody] Factura oFactura)
        {
            try
            {
                if (oFactura == null)
                {
                    return BadRequest("Se esperaba una orden de producción completa");
                }
                if (servicio.SaveFactura(oFactura))
                    return Ok("Orden registrada con éxito!");
                else
                    return StatusCode(500, "No se pudo registrar la orden!");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno, intente nuevamente!");
            }
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            if (id == null) return BadRequest("ingresar el codigo de factura que quiere eliminar");

            if (servicio.Borrar(id))
            {
                return Ok("factura eliminada correctamente");
            }

            if (servicio.Borrar(id) == false)
            {
                return BadRequest("no se pudo elliminar la factura");
            }
            else
            {
                return StatusCode(500, "factura no borrada");
            }
        }
        [HttpGet("GetFacturaById")]
        public IActionResult GetFacturaById(int nro)
        {
            if (nro == null)
            {
                return BadRequest("debe ingresar los campos de consulta");
            }
            return Ok(servicio.GetFactura(nro));
        }
        [HttpPut("Modificar")]
        public IActionResult Put(Factura O)
        {
            if (servicio.Actualizar(O))
            {
                return Ok("Factura modificada");
            }
            else
            {
                return BadRequest("no se pudo editar la factura");
            }
        }
    }
}
