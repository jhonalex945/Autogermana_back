using Catalogo.Api.Services.DTOs;
using System.Numerics;

namespace Catalogo.Api.Services
{
    public interface IVehiculoQueryService
    {
        Task<IEnumerable<VehiculoDto>> GetAllAsync();
        Task<VehiculoDto> GetAsync(int Id);
    }
}
