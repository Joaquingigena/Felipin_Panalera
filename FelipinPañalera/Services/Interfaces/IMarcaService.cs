using FelipinPañalera.DTOs;
using FelipinPañalera.Models;

namespace FelipinPañalera.Services.Interfaces
{
    public interface IMarcaService
    {
        public Task<List<MarcaDTO>> Listar();
        public Task<string> Crear(MarcaCreacionDTO marca);
        public Task<string> Modificar(int Id, MarcaCreacionDTO marca);
        public Task<string> Eliminar(int id);
        public Task<MarcaDTO> ObtenerUna(int id);
    }
}
