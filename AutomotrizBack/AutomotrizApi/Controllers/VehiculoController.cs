using AutomotrizBack.Datos.Impletacion;
using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Entidades;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutomotrizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private IVehiculoDao dao;
        public VehiculoController()
        {
            dao = new VehiculoDao();
        }
        [HttpGet("TiposVehiculos")]
        public IActionResult GetTiposV()
        {
            return Ok(dao.ObtenerTiposVehiculos());
        }

        [HttpGet("Colores")]
        public IActionResult GetColor()
        {
            return Ok(dao.ObtenerColores());
        }
        [HttpGet("Vehiculos")]
        public IActionResult GetVehiculos(decimal desde, decimal hasta, int tipov)
        {
            List<Vehiculo> lst = null;
            try
            {
                lst = dao.ObtenerVehiculosPorFiltros(desde, hasta, tipov);
                return Ok(lst);

            }
            catch (Exception )

            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        // POST api/<VehiculoController>
        [HttpPost("nuevoVehiculo")]
        public IActionResult Post(Vehiculo oVehiculo)
        {
            try
            {
                if (oVehiculo == null)
                {
                    return BadRequest("Se esperaba un vehiculo completo");
                }
                if (dao.Crear(oVehiculo))
                    return Ok("Vehiculo registrado con éxito!");
                else
                    return StatusCode(500, "No se pudo registrar el vehiculo!");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno, intente nuevamente!");
            }

        }

        // PUT api/<VehiculoController>/5
        [HttpPut("Modificar")]
        public IActionResult Put(Vehiculo oV)
        {
            if (dao.Actualizar(oV))
            {
                return Ok("Vehiculo modificado");
            }
            else
            {
                return BadRequest("No se pudo editar el vehiculo");
            }
        }
        // DELETE api/<VehiculoController>/5
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            if (id == null) return BadRequest("ingresar el codigo de vehiculo que quiere eliminar");

            if (dao.Borrar(id))
            {
                return Ok("Vehiculo eliminado correctamente");
            }

            if (dao.Borrar(id) == false)
            {
                return BadRequest("no se pudo elliminar el vehiculo");
            }
            else
            {
                return StatusCode(500, "vehiculo no borrado");
            }
        }
    }
}
