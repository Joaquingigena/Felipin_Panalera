using FelipinPañalera.Models;

namespace FelipinPañalera.Repository.Interfaces
{
    public interface IGenerycRepository<T>
        where T : class
    {
        public Task<List<T>> Listar();
        public Task<string> Crear(T entidad);
        public Task<string> Modificar(int id, T entidad);
        public Task<string> Eliminar(int id);
        public Task<T> ObtenerUno(int id);
    }
}
