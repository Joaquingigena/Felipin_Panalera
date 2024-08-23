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

            CreateMap<MarcaDTO, Marca>()
                .ReverseMap();
        
        }
    }
}
