using Comercial.Api.Services;
using Comercial.Api.Services.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Comercial.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransaccionController : ControllerBase
    {       
        private readonly ILogger<TransaccionController> _logger;
        private readonly ITransaccionQueryService _transaccionQueryService;
        private readonly IMediator _mediator;

        public TransaccionController(ILogger<TransaccionController> logger, ITransaccionQueryService transaccionQueryService, IMediator mediator)
        {
            _logger = logger;
            _transaccionQueryService = transaccionQueryService; 
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<TransaccionDto>> GetAll()
        {
            return await _transaccionQueryService.GetAsyncAll();
        }

        [HttpGet("{Id}")]
        public async Task<TransaccionDto> Get(int Id)
        {
            return await _transaccionQueryService.GetAsync(Id);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TransaccionCreateCommand transaccionCreateCommand)
        {
            await _mediator.Publish(transaccionCreateCommand);
            return Ok();
        }
    }
}
