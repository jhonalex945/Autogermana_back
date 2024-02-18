using System.ComponentModel.DataAnnotations;

namespace Cliente.Services.EventHandlers;

public partial class ClienteCreateCommand
{
    [Key]
    public int ClienteId { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }
}
