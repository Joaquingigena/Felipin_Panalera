using FelipinPañalera.Models;
using FelipinPañalera.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FelipinPañalera.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        public readonly CategoriaService _categoriaService;

        public CategoriaController(CategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> Listar()
        {
            var lista = await _categoriaService.Listar();

            return lista;
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Categoria categoria)
        {
            var rta = await _categoriaService.Crear(categoria);

            if (rta != "OK")
            {
                return BadRequest(rta);
            }

            return Ok();
        }
    }
}
