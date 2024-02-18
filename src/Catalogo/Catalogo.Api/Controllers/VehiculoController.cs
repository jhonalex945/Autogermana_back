using Catalogo.Api.Services;
using Catalogo.Api.Services.DTOs;
using Catalogo.Services.EventHandlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Catalogo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiculoController : ControllerBase
    {
        private readonly ILogger<VehiculoController> _logger;        
        private readonly IVehiculoQueryService _vehiculoQueryService;        
        private readonly IMediator _mediator;

        public VehiculoController(ILogger<VehiculoController> logger, IVehiculoQueryService vehiculoQueryService, IMediator mediator)
        {
            _logger = logger;            
            _vehiculoQueryService = vehiculoQueryService;            
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<VehiculoDto>> GetAllAsync()
        {
            return await _vehiculoQueryService.GetAllAsync();
        }

        [HttpGet("{Id}")]
        public async Task<VehiculoDto> GetAsync(int Id)
        {
            return await _vehiculoQueryService.GetAsync(Id);
        }

        [HttpPost]
        public async Task<IActionResult> Create(VehiculoCreateCommand vehiculoCreateCommand)
        {
            await _mediator.Publish(vehiculoCreateCommand);
            return Ok();
        }
    }
}
