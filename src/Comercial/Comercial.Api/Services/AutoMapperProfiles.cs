using AutoMapper;
using Comercial.Api.Models;
using Comercial.Api.Services.DTOs;

namespace Comercial.Api.Services
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<Transaccion, TransaccionDto>().ReverseMap();
        } 
    }
}
