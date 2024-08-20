using FelipinPañalera.Models;
using FelipinPañalera.Repository;
using FelipinPañalera.Services.Interfaces;

namespace FelipinPañalera.Services
{
    public class CategoriaService : ICategoriaService
    {
        public readonly CategoriaRepository _repositorio;

        public CategoriaService(CategoriaRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public Task<string> Eliminar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<string> Crear(Categoria categoria)
        {
            return _repositorio.Crear(categoria);
        }

        public Task<List<Categoria>> Listar()
        {
            return _repositorio.Listar();
        }

        public Task<string> Modificar(int Id,Categoria categoria)
        {
            return _repositorio.Modificar(Id, categoria);
        }

        public Task<Categoria> ObtenerUna(int id)
        {
            return _repositorio.ObtenerUno(id);
        }
    }
}
