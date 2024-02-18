using MediatR;

namespace Seguridad.Services.EventHandlers;

public partial class UsuarioCreateCommand : INotification
{   
    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Clave { get; set; }
}
