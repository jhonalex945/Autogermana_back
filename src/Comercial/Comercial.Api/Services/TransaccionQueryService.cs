using AutoMapper;
using Comercial.Api.Data;
using Comercial.Api.Services.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Comercial.Api.Services
{
    public class TransaccionQueryService: ITransaccionQueryService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;
        public TransaccionQueryService(ApplicationDBContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TransaccionDto>> GetAsyncAll()
        {
            var transaccion = await _dbContext.Transacciones.ToListAsync();
            return _mapper.Map<IEnumerable<TransaccionDto>>(transaccion);
        }

        public async Task<TransaccionDto> GetAsync(int Id)
        {
            var transaccion = await _dbContext.Transacciones.FindAsync(Id);
            return _mapper.Map<TransaccionDto>(transaccion);
        }
    }
}
