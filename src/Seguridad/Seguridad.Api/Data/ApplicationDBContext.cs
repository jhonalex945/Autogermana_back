using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Seguridad.Api.Models;

namespace Seguridad.Api.Data;

public partial class ApplicationDBContext : DbContext
{    
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }
}
