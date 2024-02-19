using MediatR;
using Microsoft.AspNetCore.Identity.Data;
using Seguridad.Api.Services.Response;
using System.ComponentModel.DataAnnotations;

namespace Seguridad.Services.EventHandlers;

public partial class UsuarioLoginCommand : IRequest<ResponseLogin>
{
    [Required, EmailAddress]
    public string? Usuario { get; set; }
    [Required]
    public string? Password { get; set; }
}
