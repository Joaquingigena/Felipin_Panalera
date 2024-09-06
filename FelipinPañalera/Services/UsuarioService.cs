using AutoMapper;
using FelipinPañalera.DTOs;
using FelipinPañalera.Models;
using FelipinPañalera.Repository.Interfaces;
using FelipinPañalera.Services.Interfaces;

namespace FelipinPañalera.Services
{
    public class UsuarioService : IUsuarioService
    {
        public readonly IUsuarioRepository _repositorio;
        public readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository repositorio, IMapper mapper)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }

        public async Task<string> Crear(UsuarioCreacionDTO usuario)
        {
            try
            {
                var user= _mapper.Map<Usuario>(usuario);

                return await _repositorio.Crear(user);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> Eliminar(int id)
        {
            try
            {
                return await _repositorio.Eliminar(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<UsuarioDTO>> Listar()
        {
            try
            {
                return _mapper.Map<List<UsuarioDTO>>(await _repositorio.Listar());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> Modificar(int Id, UsuarioCreacionDTO usuario)
        {
            try
            {
                var user = _mapper.Map<Usuario>(usuario);
                
                user.Id = Id;
                return await _repositorio.Modificar(Id, user);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<UsuarioDTO> ObtenerUno(int id)
        {
            try
            {
                return _mapper.Map<UsuarioDTO>(await _repositorio.ObtenerUno(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
