using MediatR;
using Microsoft.AspNetCore.Mvc;
using Seguridad.Api.Services;
using Seguridad.Api.Services.DTOs;
using Seguridad.Services.EventHandlers;

namespace Seguridad.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly IUsuarioQueryService _vehiculoQueryService;
        private readonly IMediator _mediator;

        public UsuarioController(ILogger<UsuarioController> logger, IUsuarioQueryService usuarioQueryService, IMediator mediator)
        {
            _logger = logger;
            _vehiculoQueryService = usuarioQueryService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<UsuarioDto>> GetAllAsync()
        {
            return await _vehiculoQueryService.GetAllAsync();
        }

        [HttpGet("{Id}")]
        public async Task<UsuarioDto> GetAsync(int Id)
        {
            return await _vehiculoQueryService.GetAsync(Id);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UsuarioCreateCommand usuarioCreateCommand)
        {
            await _mediator.Publish(usuarioCreateCommand);
            return Ok();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UsuarioLoginCommand usuarioLoginCommand)
        {
            if(ModelState.IsValid)
            {
                var result = await _mediator.Send(usuarioLoginCommand);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);
            }

            return BadRequest("Error de datos obligatorios.");
        }
    }
}
