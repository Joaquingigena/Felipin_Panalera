using FelipinPañalera.DTOs;
using FelipinPañalera.Models;

namespace FelipinPañalera.Services.Interfaces
{
    public interface IProductoService
    {
        public Task<List<ProductoDTO>> Listar();
        public Task<string> Crear(Producto producto);
        public Task<string> Modificar(int Id, Producto producto);
        public Task<string> Eliminar(int id);
        public Task<ProductoDTO> ObtenerUna(int id);
    }
}
