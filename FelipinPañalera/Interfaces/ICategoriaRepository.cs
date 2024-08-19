using FelipinPañalera.Models;

namespace FelipinPañalera.Interfaces
{
    public interface ICategoriaRepository
    {
        public Task<List<Categoria>> Listar();
        public Task<bool> Crear(Categoria categoria);
        public Task<bool> Eliminar { get; set; }
    }
}
