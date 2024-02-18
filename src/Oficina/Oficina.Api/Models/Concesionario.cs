using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oficina.Api.Models;

[Table("Concesionario", Schema = "Oficina")]
public partial class Concesionario
{
    [Key]
    public int ConcesionarioId { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }
}
