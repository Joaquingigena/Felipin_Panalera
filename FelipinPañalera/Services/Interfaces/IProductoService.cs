using FelipinPañalera.DTOs;
using FelipinPañalera.Models;

namespace FelipinPañalera.Services.Interfaces
{
    public interface IProductoService
    {
        public Task<List<ProductoDTO>> Listar();
        public Task<string> Crear(ProductoCreacionDTO producto);
        public Task<string> Modificar(int Id, ProductoCreacionDTO producto);
        public Task<string> Eliminar(int id);
        public Task<ProductoDTO> ObtenerUna(int id);
    }
}
