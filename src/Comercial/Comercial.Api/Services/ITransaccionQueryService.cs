using Comercial.Api.Services.DTOs;

namespace Comercial.Api.Services
{
    public interface ITransaccionQueryService
    {
        Task<IEnumerable<TransaccionDto>> GetAsyncAll();
        Task<TransaccionDto> GetAsync(int Id);
    }
}
