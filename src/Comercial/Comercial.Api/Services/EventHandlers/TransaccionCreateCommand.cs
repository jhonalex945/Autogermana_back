using MediatR;
using System;
using System.Collections.Generic;

namespace Comercial.Api.Services.DTOs;

public partial class TransaccionCreateCommand: INotification
{
    public int TransaccionId { get; set; }

    public int? VehiculoId { get; set; }

    public int? ClienteId { get; set; }

    public int? ConcesionarioId { get; set; }

    public DateTime? FechaVenta { get; set; }

    public decimal? PrecioVenta { get; set; }
}
