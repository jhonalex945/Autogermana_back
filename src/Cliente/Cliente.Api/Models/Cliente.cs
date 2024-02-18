using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cliente.Api.Models;

[Table("Cliente", Schema = "Cliente")]
public partial class Cliente
{
    [Key]
    public int ClienteId { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }
}
