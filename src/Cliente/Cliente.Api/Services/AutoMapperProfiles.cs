using AutoMapper;
using Cliente.Services.DTOs;

namespace Cliente.Api.Services
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles() { 
            CreateMap<Models.Cliente, ClienteDto>().ReverseMap();
        }
    }
}
