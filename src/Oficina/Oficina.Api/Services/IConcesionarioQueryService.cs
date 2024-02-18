using Oficina.Api.Services.DTOs;
using Oficina.Api.Services.EventHandlers;

namespace Oficina.Api.Services
{
    public interface IConcesionarioQueryService
    {
        Task<IEnumerable<ConcesionarioCreateCommand>> GetAsyncAll();
        Task<ConcesionarioCreateCommand> GetAsync(int Id);
    }
}
