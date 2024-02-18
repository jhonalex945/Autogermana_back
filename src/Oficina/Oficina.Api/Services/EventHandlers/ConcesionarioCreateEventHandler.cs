using Oficina.Api.Data;
using Oficina.Api.Models;

namespace Oficina.Api.Services.EventHandlers
{
    public class ConcesionarioCreateEventHandler
    {
        private readonly ApplicationDBContext _dbContext;
        public ConcesionarioCreateEventHandler(ApplicationDBContext context ) 
        { 
            _dbContext = context;
        }

        public async Task Handler(ConcesionarioCreateCommand consesionarioCreateCommand)
        {
            await _dbContext.AddAsync(new Concesionario {
                Ciudad = consesionarioCreateCommand.Ciudad,
                Direccion = consesionarioCreateCommand.Direccion,
                Nombre = consesionarioCreateCommand.Nombre
            });

            await _dbContext.SaveChangesAsync();
        }
    }
}
