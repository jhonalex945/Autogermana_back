using AutoMapper;
using Catalogo.Api.Models;
using Catalogo.Api.Services.DTOs;

namespace Catalogo.Api.Services
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Vehiculo, VehiculoDto>().ReverseMap();
        }
    }
}
