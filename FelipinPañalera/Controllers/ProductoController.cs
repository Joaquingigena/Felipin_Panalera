using FelipinPañalera.DTOs;
using FelipinPañalera.Models;
using FelipinPañalera.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FelipinPañalera.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        public readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        [Route("Listar")]
        public async Task<ActionResult<List<ProductoDTO>>> Listar()
        {
            var lista = await _productoService.Listar();

            return Ok(lista);
        }

        [HttpPost]
        [Route("Agregar")]
        public async Task<ActionResult> Crear(Producto producto)
        {
            var rta = await _productoService.Crear(producto);

            if (rta != "OK")
            {
                return BadRequest(rta);
            }

            return Ok();
        }

        [HttpGet]
        [Route("ObtenerUno/{id:int}")]
        public async Task<ActionResult<ProductoDTO>> ObtenerUno(int id)
        {
            try
            {
                var producto = await _productoService.ObtenerUna(id);

                return Ok(producto);
            }
            catch (Exception ex)
            {
                return NotFound(ex.ToString());

            }
        }

        [HttpPut]
        [Route("Modificar")]
        public async Task<ActionResult> Modificar(int id, Producto producto)
        {
            var rta = await _productoService.Modificar(id, producto);

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
            var rta = await _productoService.Eliminar(id);

            if (rta != "OK")
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
