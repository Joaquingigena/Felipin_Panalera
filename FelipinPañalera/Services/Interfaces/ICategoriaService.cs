using FelipinPañalera.DTOs;
using FelipinPañalera.Models;

namespace FelipinPañalera.Services.Interfaces
{
    public interface ICategoriaService
    {
        public Task<List<CategoriaDTO>> Listar();
        public Task<string> Crear(CategoriaCreacionDTO categoria);
        public Task<string> Modificar(int Id,CategoriaCreacionDTO categoria);
        public Task<string> Eliminar(int id);
        public Task<CategoriaDTO> ObtenerUna(int id);
    }
}
