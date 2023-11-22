using AutomotrizBack.Datos.Impletacion;
using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Entidades;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutomotrizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoparteController : ControllerBase
    {
        private IAutoparteDao dao;
        public AutoparteController()
        {
            dao = new AutoparteDao();
        }
        [HttpGet("TiposAutopartes")]
        public IActionResult GetTiposA()
        {
            return Ok(dao.ObtenerTiposA());
        }


        [HttpGet("Autopartes")]
        public IActionResult GetAutopartes(int stock, int tipoa)
        {
            List<Autoparte> lst = null;
            try
            {
                lst = dao.ObtenerAutopartesPorFiltros(stock,tipoa);
                return Ok(lst);

            }
            catch (Exception )

            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        // POST api/<VehiculoController>
        [HttpPost("nuevaAutoparte")]
        public IActionResult Post(Autoparte oAutoparte)
        {
            try
            {
                if (oAutoparte == null)
                {
                    return BadRequest("Se esperaba una autoparte completa");
                }
                if (dao.Crear(oAutoparte))
                    return Ok("Autoparte registrada con éxito!");
                else
                    return StatusCode(500, "No se pudo registrar la autoparte!");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno, intente nuevamente!");
            }

        }

        // PUT api/<VehiculoController>/5
        [HttpPut("Modificar")]
        public IActionResult Put(Autoparte oAuto)
        {
            if (dao.Actualizar(oAuto))
            {
                return Ok("Autoparte modificada");
            }
            else
            {
                return BadRequest("No se pudo editar la autoparte");
            }
        }

        // DELETE api/<VehiculoController>/5
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            if (id == null) return BadRequest("ingresar el codigo de autoparte que quiere eliminar");

            if (dao.Borrar(id))
            {
                return Ok("Autoparte eliminada correctamente");
            }

            if (dao.Borrar(id) == false)
            {
                return BadRequest("No se pudo elliminar la autoparte");
            }
            else
            {
                return StatusCode(500, "autoparte no borrada");
            }
        }
    }
}
