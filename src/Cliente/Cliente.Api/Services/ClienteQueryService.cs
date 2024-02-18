using AutoMapper;
using Cliente.Api.Data;
using Cliente.Services.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Cliente.Api.Services
{
    public class ClienteQueryService: IClienteQueryService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;
        public ClienteQueryService(ApplicationDBContext context, IMapper mapper)
        {
            _dbContext = context; 
            _mapper = mapper;
        }
        public async Task<IEnumerable<ClienteDto>> GetAllAsync()
        {
            var lstClientes = await _dbContext.Clientes.ToListAsync();
            return _mapper.Map<IEnumerable<ClienteDto>>(lstClientes);
        }
        public async Task<ClienteDto> GetAsync(int Id)
        {
            var cliente = await _dbContext.Clientes.FindAsync(Id);
            return _mapper.Map<ClienteDto>(cliente);
        }
    }
}
