using FelipinPañalera.Models;

namespace FelipinPañalera.Services.Interfaces
{
    public interface IMarcaService
    {
        public Task<List<Marca>> Listar();
        public Task<string> Crear(Marca marca);
        public Task<string> Modificar(int Id, Marca marca);
        public Task<string> Eliminar(int id);
        public Task<Marca> ObtenerUna(int id);
    }
}
