using System;
using System.Collections.Generic;
using Catalogo.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Api.Data;

public partial class ApplicationDBContext : DbContext
{    
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
    }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }    
}
