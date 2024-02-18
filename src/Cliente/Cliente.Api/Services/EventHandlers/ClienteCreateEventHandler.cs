using Cliente.Api.Data;
using Cliente.Services.DTOs;
using Cliente.Services.EventHandlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cliente.Api.Services.EventHandlers
{
    public class ClienteCreateEventHandler: INotification
    {
        private readonly ApplicationDBContext _dbContext;
        public ClienteCreateEventHandler(ApplicationDBContext context) {
            _dbContext = context;
        }

        public async Task Handle(ClienteCreateCommand clienteCreateCommand) 
        {
            await _dbContext.AddAsync( new Models.Cliente
            {
                Email = clienteCreateCommand.Email,
                Nombre = clienteCreateCommand.Nombre,
                Telefono = clienteCreateCommand.Telefono,
            } );

            _dbContext.SaveChanges();
        }
    }
}
