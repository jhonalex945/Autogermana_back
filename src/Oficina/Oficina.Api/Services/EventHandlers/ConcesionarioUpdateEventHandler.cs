using Oficina.Api.Data;
using Oficina.Api.Models;

namespace Oficina.Api.Services.EventHandlers
{
    public class ConcesionarioUpdateEventHandler
    {
        private readonly ApplicationDBContext _dbContext;
        public ConcesionarioUpdateEventHandler(ApplicationDBContext context ) 
        { 
            _dbContext = context;
        }

        public async Task Handler(ConcesionarioUpdateCommand consesionarioUpdateCommand)
        {
            Concesionario concesionario = new Concesionario();

            concesionario.ConcesionarioId = consesionarioUpdateCommand.ConcesionarioId;
            concesionario.Ciudad = consesionarioUpdateCommand.Ciudad;
            concesionario.Direccion = consesionarioUpdateCommand.Direccion;
            concesionario.Nombre = consesionarioUpdateCommand.Nombre;

            _dbContext.Update(concesionario);

            await _dbContext.SaveChangesAsync();
        }
    }
}
