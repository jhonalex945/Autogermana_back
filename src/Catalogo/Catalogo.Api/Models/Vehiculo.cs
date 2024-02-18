using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalogo.Api.Models;
[Table(name:"Vehiculo", Schema ="Catalogo")]
public partial class Vehiculo
{
    public int VehiculoId { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public int? Anio { get; set; }

    public decimal? Precio { get; set; }
}
