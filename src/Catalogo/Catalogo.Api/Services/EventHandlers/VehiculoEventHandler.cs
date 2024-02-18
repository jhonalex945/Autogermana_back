using Catalogo.Api.Data;
using Catalogo.Api.Models;
using Catalogo.Services.EventHandlers;
using MediatR;

namespace Catalogo.Api.Services.EventHandlers
{
    public class VehiculoEventHandler: INotificationHandler<VehiculoCreateCommand>
    {
        private readonly ApplicationDBContext _dBContext;
        public VehiculoEventHandler(ApplicationDBContext dBContext) 
        { 
            _dBContext = dBContext;
        }

        public async Task Handle(VehiculoCreateCommand vehiculoCreateCommand, CancellationToken cancellationToken)
        {
            await _dBContext.AddAsync(new Vehiculo
            {
                Anio = vehiculoCreateCommand.Anio,
                Marca = vehiculoCreateCommand.Marca,
                Modelo = vehiculoCreateCommand.Modelo,
                Precio = vehiculoCreateCommand.Precio                
            });

            await _dBContext.SaveChangesAsync();
        }        
    }
}
