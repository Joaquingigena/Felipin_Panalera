using AutoMapper;
using FelipinPañalera.DTOs;
using FelipinPañalera.Models;
using FelipinPañalera.Repository.Interfaces;
using FelipinPañalera.Services.Interfaces;

namespace FelipinPañalera.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repositorio;
        private readonly IMapper _mapper;

        public ProductoService(IProductoRepository repository,IMapper mapper)
        {
            _repositorio = repository;
            _mapper = mapper;
        }
        public async Task<string> Crear(Producto producto)
        {
            return await _repositorio.Crear(producto);
        }

        public async Task<string> Eliminar(int id)
        {
            return await _repositorio.Eliminar(id);
        }

        public async Task<List<ProductoDTO>> Listar()
        {
            var productosDTO=  _mapper.Map<List<ProductoDTO>>(await _repositorio.Listar());

            return productosDTO;
        }

        public async Task<string> Modificar(int Id, Producto producto)
        {
            return await _repositorio.Modificar(Id, producto);
        }

        public async Task<ProductoDTO> ObtenerUna(int id)
        {
            var productoDTO= _mapper.Map<ProductoDTO>(await _repositorio.ObtenerUno(id));

            return productoDTO;
        }
    }
}
