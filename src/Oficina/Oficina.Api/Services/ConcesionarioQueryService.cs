using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Oficina.Api.Data;
using Oficina.Api.Services.DTOs;
using Oficina.Api.Services.EventHandlers;

namespace Oficina.Api.Services
{
    public class ConcesionarioQueryService: IConcesionarioQueryService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;   
        public ConcesionarioQueryService(ApplicationDBContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ConcesionarioCreateCommand>> GetAsyncAll()
        {
            var lstConsesionarios = await _dbContext.Concesionarios.ToListAsync();
            return _mapper.Map<IEnumerable<ConcesionarioCreateCommand>>(lstConsesionarios);
        }

        public async Task<ConcesionarioCreateCommand> GetAsync(int Id)
        {
            var consesionarios = await _dbContext.Concesionarios.FindAsync(Id);
            return _mapper.Map<ConcesionarioCreateCommand>(consesionarios);
        }

    }
}
