using Comercial.Api.Data;
using Comercial.Api.Models;
using Comercial.Api.Services.DTOs;
using MediatR;

namespace Comercial.Api.Services.EventHandlers
{
    public class TransactionCreateEventHandler: INotificationHandler<TransaccionCreateCommand>
    {
        private readonly ApplicationDBContext _dbContext;

        public TransactionCreateEventHandler(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        
        public async Task Handle(TransaccionCreateCommand transaccionCreateCommand, CancellationToken cancellationToken)
        {
            await _dbContext.AddAsync(new Transaccion
            {
                TransaccionId = transaccionCreateCommand.TransaccionId,
                ClienteId = transaccionCreateCommand.ClienteId,
                ConcesionarioId = transaccionCreateCommand.ConcesionarioId,
                FechaVenta = transaccionCreateCommand.FechaVenta,
                PrecioVenta = transaccionCreateCommand.PrecioVenta,
                VehiculoId = transaccionCreateCommand.VehiculoId                
            });

            _dbContext.SaveChanges();
        }

    }
}
