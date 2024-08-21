using FelipinPañalera.Models;
using FelipinPañalera.Repository.Interfaces;
using FelipinPañalera.Services.Interfaces;

namespace FelipinPañalera.Services
{
    public class MarcaService : IMarcaService
    {
        public readonly IMarcaRepository _repositorio;

        public MarcaService(IMarcaRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public Task<string> Eliminar (int id)
        {
            return _repositorio.Eliminar (id);
        }

        public Task<string> Crear(Marca marca)
        {
            return _repositorio.Crear(marca);
        }

        public Task<List<Marca>> Listar()
        {
            return _repositorio.Listar();
        }
        public Task<string> Modificar(int Id, Marca marca)
        {
            return _repositorio.Modificar(Id, marca);
        }

        public Task<Marca> ObtenerUna(int id)
        {
            return _repositorio.ObtenerUno(id);
        }
    }
}
