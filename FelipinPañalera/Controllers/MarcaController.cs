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
    public class MarcaController : ControllerBase
    {
        public readonly IMarcaService _service;

        public MarcaController(IMarcaService service)
        {
            _service = service;
        }


        [HttpGet]
        [Route("Listar")]
        public async Task<ActionResult<List<MarcaDTO>>> Listar()
        {
            var lista = await _service.Listar();

            return Ok(lista);
        }

        [HttpPost]
        [Route("Agregar")]
        public async Task<ActionResult> Crear(Marca marca)
        {
            var rta = await _service.Crear(marca);

            if (rta != "OK")
            {
                return BadRequest(rta);
            }

            return Ok();
        }

        [HttpGet]
        [Route("ObtenerUna/{id:int}")]
        public async Task<ActionResult<MarcaDTO>> ObtenerUna(int id)
        {
            try
            {
                var marca = await _service.ObtenerUna(id);

                return Ok(marca);
            }
            catch (Exception ex)
            {
                return NotFound(ex.ToString());

            }
        }

        [HttpPut]
        [Route("Modificar")]
        public async Task<ActionResult> Modificar(int id, Marca marca)
        {
            var rta = await _service.Modificar(id, marca);

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
