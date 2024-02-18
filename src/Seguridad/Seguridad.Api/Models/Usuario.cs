using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seguridad.Api.Models;
[Table(name:"Usuario", Schema = "Seguridad")]
public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Clave { get; set; }
}
