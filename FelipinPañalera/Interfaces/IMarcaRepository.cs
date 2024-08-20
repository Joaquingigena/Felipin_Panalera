using FelipinPañalera.Models;

namespace FelipinPañalera.Interfaces
{
    public interface IMarcaRepository
    {
        public Task<List<Marca>> Listar();
        public Task<bool> Crear(Marca marca);
        public Task<bool> Modificar(Marca marca);
        public Task<bool> Eliminar { get; set; }
    }
}
