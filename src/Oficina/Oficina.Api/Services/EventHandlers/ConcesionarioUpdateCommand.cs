using System.ComponentModel.DataAnnotations;

namespace Oficina.Api.Services.EventHandlers;
public partial class ConcesionarioUpdateCommand
{
    [Key]
    public int ConcesionarioId { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }
}
