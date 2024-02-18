using System;
using System.Collections.Generic;

namespace Seguridad.Api.Services.DTOs;

public partial class UsuarioDto
{
    public int UsuarioId { get; set; }
    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Clave { get; set; }
}
