using FelipinPañalera.DTOs;
using FelipinPañalera.Models;

namespace FelipinPañalera.Services.Interfaces
{
    public interface IMarcaService
    {
        public Task<List<MarcaDTO>> Listar();
        public Task<string> Crear(Marca marca);
        public Task<string> Modificar(int Id, Marca marca);
        public Task<string> Eliminar(int id);
        public Task<MarcaDTO> ObtenerUna(int id);
    }
}
