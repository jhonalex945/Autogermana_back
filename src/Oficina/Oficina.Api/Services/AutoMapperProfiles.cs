using AutoMapper;
using Oficina.Api.Models;
using Oficina.Api.Services.DTOs;

namespace Oficina.Api.Services
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Concesionario, ConcesionarioDto>().ReverseMap();
        }

    }
}
