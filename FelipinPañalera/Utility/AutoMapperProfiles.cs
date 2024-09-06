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


            CreateMap<Producto, ProductoDTO>()
                .ForMember(ent => ent.NombreMarca,
                dto => dto.MapFrom(origen => origen.Marca.Nombre))
                .ForMember(ent => ent.NombreCategoria,
                dto => dto.MapFrom(origen => origen.Categoria.Nombre));


            CreateMap<Producto, ProductoCreacionDTO>()
                .ReverseMap();


            //CreateMap<Movimiento, MovimientoDTO>()
            // .ForMember(ent => ent.DescripcionTipoMovimiento,
            // dto => dto.MapFrom(origen => origen.TipoMovimiento.Nombre))
            // .ForMember(ent => ent.DescripcionCategoria,
            // dto => dto.MapFrom(origen => origen.Categoria.Nombre));
        }
    }
}
