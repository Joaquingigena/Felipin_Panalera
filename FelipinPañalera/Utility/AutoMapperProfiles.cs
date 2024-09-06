using AutoMapper;
using FelipinPañalera.DTOs;
using FelipinPañalera.Models;

namespace FelipinPañalera.Utility
{
    public class AutoMapperProfiles :Profile
    {
        public AutoMapperProfiles() {

            CreateMap<CategoriaDTO, Categoria>()
                .ReverseMap();
            CreateMap<Categoria, CategoriaCreacionDTO>()
                .ReverseMap();


            CreateMap<MarcaDTO, Marca>()
                .ReverseMap();
            CreateMap<Marca, MarcaCreacionDTO>()
                .ReverseMap();


            CreateMap<UsuarioDTO, Usuario>()
                .ReverseMap();
            CreateMap<Usuario, UsuarioCreacionDTO>()
                .ReverseMap();


            CreateMap<ProductoDTO,Producto>()
                .ReverseMap();
        
        }
    }
}
