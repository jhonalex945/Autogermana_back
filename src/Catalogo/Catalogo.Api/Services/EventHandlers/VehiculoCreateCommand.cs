using MediatR;

namespace Catalogo.Services.EventHandlers;

public partial class VehiculoCreateCommand : INotification
{    
    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public int? Anio { get; set; }

    public decimal? Precio { get; set; }
}
