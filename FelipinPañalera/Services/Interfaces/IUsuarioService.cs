using FelipinPañalera.DTOs;
using FelipinPañalera.Models;

namespace FelipinPañalera.Services.Interfaces
{
    public interface IUsuarioService
    {
        public Task<List<UsuarioDTO>> Listar();
        public Task<string> Crear(UsuarioCreacionDTO usuario);
        public Task<string> Modificar(int Id, UsuarioCreacionDTO usuario);
        public Task<string> Eliminar(int id);
        public Task<UsuarioDTO> ObtenerUno(int id);
    }
}
