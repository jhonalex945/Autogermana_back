using Seguridad.Api.Services.DTOs;

namespace Seguridad.Api.Services
{
    public interface IUsuarioQueryService
    {
        Task<IEnumerable<UsuarioDto>> GetAllAsync();
        Task<UsuarioDto> GetAsync(int Id);
    }
}
