using AutoMapper;
using Catalogo.Api.Data;
using Catalogo.Api.Services.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Catalogo.Api.Services
{
    public class VehiculoQueryService: IVehiculoQueryService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;
        public VehiculoQueryService(ApplicationDBContext dBContext, IMapper mapper)
        {
            _dbContext = dBContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VehiculoDto>> GetAllAsync()
        {
            var lstVehiculos = await _dbContext.Vehiculos.ToListAsync();
            return _mapper.Map<IEnumerable<VehiculoDto>>(lstVehiculos);
        }

        public async Task<VehiculoDto> GetAsync(int Id)
        {
            var vehiculo = await _dbContext.Vehiculos.FindAsync(Id);
            return _mapper.Map<VehiculoDto>(vehiculo);
        }
    }
}
