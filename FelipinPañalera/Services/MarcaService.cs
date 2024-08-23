using AutoMapper;
using FelipinPañalera.DTOs;
using FelipinPañalera.Models;
using FelipinPañalera.Repository.Interfaces;
using FelipinPañalera.Services.Interfaces;

namespace FelipinPañalera.Services
{
    public class MarcaService : IMarcaService
    {
        public readonly IMarcaRepository _repositorio;
        public readonly IMapper _mapper;

        public MarcaService(IMarcaRepository repositorio,IMapper mapper)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }

        public Task<string> Eliminar (int id)
        {
            return _repositorio.Eliminar (id);
        }

        public Task<string> Crear(Marca marca)
        {
            return _repositorio.Crear(marca);
        }

        public async Task<List<MarcaDTO>> Listar()
        {
            return _mapper.Map<List<MarcaDTO>>(await _repositorio.Listar());
        }
        public Task<string> Modificar(int Id, Marca marca)
        {
            return _repositorio.Modificar(Id, marca);
        }

        public async Task<MarcaDTO> ObtenerUna(int id)
        {
            return _mapper.Map<MarcaDTO>(await _repositorio.ObtenerUno(id));
        }
    }
}
