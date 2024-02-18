using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comercial.Api.Models;
[Table("Transaccion", Schema = "Comercial")]
public partial class Transaccion
{
    public int TransaccionId { get; set; }

    public int? VehiculoId { get; set; }

    public int? ClienteId { get; set; }

    public int? ConcesionarioId { get; set; }

    public DateTime? FechaVenta { get; set; }

    public decimal? PrecioVenta { get; set; }
}
