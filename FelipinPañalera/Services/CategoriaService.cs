using AutoMapper;
using FelipinPañalera.DTOs;
using FelipinPañalera.Models;
using FelipinPañalera.Repository;
using FelipinPañalera.Repository.Interfaces;
using FelipinPañalera.Services.Interfaces;

namespace FelipinPañalera.Services
{
    public class CategoriaService : ICategoriaService
    {
        public readonly ICategoriaRepository _repositorio;
        public readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository repositorio,IMapper mapper)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }

        public async Task<string> Eliminar(int id)
        {
            return await _repositorio.Eliminar(id);
        }

        public async Task<string> Crear(CategoriaCreacionDTO categoria)
        {
            var cat= _mapper.Map<Categoria>(categoria);

            return await _repositorio.Crear(cat);
        }

        public async Task<List<CategoriaDTO>> Listar()
        {
            return  _mapper.Map<List<CategoriaDTO>>( await _repositorio.Listar());
            
        }

        public async Task<string> Modificar(int Id,CategoriaCreacionDTO categoria)
        {
            var cat = _mapper.Map<Categoria>(categoria);

            cat.Id = Id;

            return await _repositorio.Modificar(Id, cat);
        }

        public async Task<CategoriaDTO> ObtenerUna(int id)
        {
            return _mapper.Map<CategoriaDTO>(await _repositorio.ObtenerUno(id));
        }
    }
}
