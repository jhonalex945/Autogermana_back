using System;
using System.Collections.Generic;
using Comercial.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Comercial.Api.Data;

public partial class ApplicationDBContext : DbContext
{    
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
    }

    public virtual DbSet<Transaccion> Transacciones { get; set; }
}
