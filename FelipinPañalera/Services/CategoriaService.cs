using FelipinPañalera.Models;
using FelipinPañalera.Repository;
using FelipinPañalera.Repository.Interfaces;
using FelipinPañalera.Services.Interfaces;

namespace FelipinPañalera.Services
{
    public class CategoriaService : ICategoriaService
    {
        public readonly ICategoriaRepository _repositorio;

        public CategoriaService(ICategoriaRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<string> Eliminar(int id)
        {
            return await _repositorio.Eliminar(id);
        }

        public async Task<string> Crear(Categoria categoria)
        {
            return await _repositorio.Crear(categoria);
        }

        public async Task<List<Categoria>> Listar()
        {
            return await _repositorio.Listar();
        }

        public async Task<string> Modificar(int Id,Categoria categoria)
        {
            return await _repositorio.Modificar(Id, categoria);
        }

        public async Task<Categoria> ObtenerUna(int id)
        {
            return await _repositorio.ObtenerUno(id);
        }
    }
}
