using AutoMapper;
using Seguridad.Api.Models;
using Seguridad.Api.Services.DTOs;

namespace Seguridad.Api.Services
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
        }
    }
}
