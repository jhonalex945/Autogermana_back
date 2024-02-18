using System;
using System.Collections.Generic;
using Cliente.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Cliente.Api.Data;

public partial class ApplicationDBContext : DbContext
{    
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
    }

    public virtual DbSet<Models.Cliente> Clientes { get; set; }    
}
