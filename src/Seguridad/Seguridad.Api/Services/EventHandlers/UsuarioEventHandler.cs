using MediatR;
using Seguridad.Api.Data;
using Seguridad.Api.Models;

namespace Seguridad.Services.EventHandlers
{
    public class UsuarioEventHandler: INotificationHandler<UsuarioCreateCommand>
    {
        private readonly ApplicationDBContext _dBContext;
        public UsuarioEventHandler(ApplicationDBContext dBContext) 
        { 
            _dBContext = dBContext;
        }

        public async Task Handle(UsuarioCreateCommand usuarioCreateCommand, CancellationToken cancellationToken)
        {
            await _dBContext.AddAsync(new Usuario
            {
                Clave = usuarioCreateCommand.Clave,
                Email = usuarioCreateCommand.Email, 
                Nombre = usuarioCreateCommand.Nombre,                        
            });

            await _dBContext.SaveChangesAsync();
        }        
    }
}
