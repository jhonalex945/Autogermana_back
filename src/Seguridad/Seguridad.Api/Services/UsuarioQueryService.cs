using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Seguridad.Api.Data;
using Seguridad.Api.Services.DTOs;

namespace Seguridad.Api.Services
{
    public class UsuarioQueryService: IUsuarioQueryService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;
        public UsuarioQueryService(ApplicationDBContext dBContext, IMapper mapper)
        {
            _dbContext = dBContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UsuarioDto>> GetAllAsync()
        {
            var lstUsuarios = await _dbContext.Usuarios.ToListAsync();
            return _mapper.Map<IEnumerable<UsuarioDto>>(lstUsuarios);
        }

        public async Task<UsuarioDto> GetAsync(int Id)
        {
            var usuario = await _dbContext.Usuarios.FindAsync(Id);
            return _mapper.Map<UsuarioDto>(usuario);
        }
    }
}
