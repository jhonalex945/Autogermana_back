using Cliente.Services.DTOs;

namespace Cliente.Api.Services
{
    public interface IClienteQueryService
    {
        Task<IEnumerable<ClienteDto>> GetAllAsync();
        Task<ClienteDto> GetAsync(int Id);
    }
}
