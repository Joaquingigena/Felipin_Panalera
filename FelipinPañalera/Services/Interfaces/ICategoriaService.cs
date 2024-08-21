using FelipinPañalera.Models;

namespace FelipinPañalera.Services.Interfaces
{
    public interface ICategoriaService
    {
        public Task<List<Categoria>> Listar();
        public Task<string> Crear(Categoria categoria);
        public Task<string> Modificar(int Id,Categoria categoria);
        public Task<string> Eliminar(int id);
        public Task<Categoria> ObtenerUna(int id);
    }
}
