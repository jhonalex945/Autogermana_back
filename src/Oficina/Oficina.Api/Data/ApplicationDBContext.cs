using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Oficina.Api.Models;

namespace Oficina.Api.Data;

public partial class ApplicationDBContext : DbContext
{    
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
    }

    public virtual DbSet<Concesionario> Concesionarios { get; set; }    
}
