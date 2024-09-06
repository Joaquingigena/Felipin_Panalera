using FelipinPañalera.DTOs;
using FelipinPañalera.Models;
using FelipinPañalera.Services;
using FelipinPañalera.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FelipinPañalera.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("Listar")]
        public async Task<ActionResult<List<UsuarioDTO>>> Listar()
        {
            var lista = await _service.Listar();

            return Ok(lista);
        }

        [HttpPost]
        [Route("Agregar")]
        public async Task<ActionResult> Crear(UsuarioCreacionDTO usuario)
        {
            var rta = await _service.Crear(usuario);

            if (rta != "OK")
            {
                return BadRequest(rta);
            }

            return Ok();
        }

        [HttpGet]
        [Route("ObtenerUna/{id:int}")]
        public async Task<ActionResult<UsuarioDTO>> ObtenerUno(int id)
        {
            try
            {
                var categoria = await _service.ObtenerUno(id);

                return Ok(categoria);
            }
            catch (Exception ex)
            {
                return NotFound(ex.ToString());

            }
        }

        [HttpPut]
        [Route("Modificar")]
        public async Task<ActionResult> Modificar(int id, UsuarioCreacionDTO usuario)
        {
            var rta = await _service.Modificar(id, usuario);

            if (rta != "OK")
            {
                return NotFound(rta);
            }

            return Ok();
        }

        [HttpDelete]
        [Route("Eliminar/{id:int}")]
        public async Task<ActionResult> Eliminar(int id)
        {
            var rta = await _service.Eliminar(id);

            if (rta != "OK")
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
