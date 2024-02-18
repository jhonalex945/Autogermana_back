using Microsoft.AspNetCore.Mvc;
using Oficina.Api.Models;
using Oficina.Api.Services;
using Oficina.Api.Services.DTOs;
using Oficina.Api.Services.EventHandlers;

namespace Oficina.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsecionarioController : ControllerBase
    {        
        private readonly ILogger<ConsecionarioController> _logger;
        private readonly IConcesionarioQueryService _concesionarioQueryService;

        public ConsecionarioController(ILogger<ConsecionarioController> logger, IConcesionarioQueryService concesionarioQueryService)
        {
            _logger = logger;
           _concesionarioQueryService = concesionarioQueryService;
        }

        [HttpGet]
        public async Task<IEnumerable<ConcesionarioCreateCommand>> GetAll()
        {
            return await _concesionarioQueryService.GetAsyncAll();
        }

        [HttpGet("{Id}")]
        public async Task<ConcesionarioCreateCommand> Get(int Id)
        {
            return await _concesionarioQueryService.GetAsync(Id);
        }
    }
}
