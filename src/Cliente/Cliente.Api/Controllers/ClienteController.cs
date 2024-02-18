using Cliente.Api.Services;
using Cliente.Services.DTOs;
using Cliente.Services.EventHandlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cliente.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {        
        private readonly ILogger<ClienteController> _logger;
        private readonly IClienteQueryService _clienteQueryService;
        private readonly IMediator _mediator;

        public ClienteController(ILogger<ClienteController> logger, IClienteQueryService clienteQueryService, IMediator mediator)
        {
            _logger = logger;
            _clienteQueryService = clienteQueryService;
            _mediator = mediator;
        }        

        [HttpGet]
        public async Task<IEnumerable<ClienteDto>> GetAll()
        {
            return await _clienteQueryService.GetAllAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ClienteDto> Get(int Id)
        {
            return await _clienteQueryService.GetAsync(Id);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ClienteCreateCommand clienteCreateCommand)
        {
            await _mediator.Publish(clienteCreateCommand);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ClienteUpdateCommand clienteUpdateCommand)
        {
            await _mediator.Publish(clienteUpdateCommand);
            return Ok();
        }
    }
}
