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
    public class CategoriaController : ControllerBase
    {

        public readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        [Route("Listar")]
        public async Task<ActionResult<List<CategoriaDTO>>> Listar()
        {
            var lista = await _categoriaService.Listar();

            return Ok(lista);
        }

        [HttpPost]
        [Route("Agregar")]
        public async Task<ActionResult> Crear(Categoria categoria)
        {
            var rta = await _categoriaService.Crear(categoria);

            if (rta != "OK")
            {
                return BadRequest(rta);
            }

            return Ok();
        }

        [HttpGet]
        [Route("ObtenerUna/{id:int}")]
        public async Task<ActionResult<CategoriaDTO>> ObtenerUnar(int id)
        {
            try
            {
                var categoria = await _categoriaService.ObtenerUna(id);

                return Ok(categoria);
            }
            catch (Exception ex)
            {
                return NotFound(ex.ToString());
                
            }
        }

        [HttpPut]
        [Route("Modificar")]
        public async Task<ActionResult> Modificar(int id,Categoria categoria)
        {
            var rta = await _categoriaService.Modificar(id,categoria);

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
            var rta = await _categoriaService.Eliminar(id);

            if (rta != "OK")
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
