using Cliente.Api.Data;
using Cliente.Services.EventHandlers;
using MediatR;

namespace Cliente.Api.Services.EventHandlers
{
    public class ClienteUpdateEventHandler: INotification
    {
        private readonly ApplicationDBContext _dbContext;
        public ClienteUpdateEventHandler(ApplicationDBContext context) {
            _dbContext = context;
        }

        public async Task Handle(ClienteUpdateCommand clienteUpdateCommand) 
        {
            Models.Cliente cliente = new Models.Cliente();

            cliente.Email = clienteUpdateCommand.Email;
            cliente.Nombre = clienteUpdateCommand.Nombre;
            cliente.Telefono = clienteUpdateCommand.Telefono;
            
            _dbContext.Update(cliente);
            await _dbContext.SaveChangesAsync();
        }
    }
}
