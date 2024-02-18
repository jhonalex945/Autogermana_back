using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oficina.Api.Services.DTOs;
public partial class ConcesionarioDto
{
    [Key]
    public int ConcesionarioId { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }
}
