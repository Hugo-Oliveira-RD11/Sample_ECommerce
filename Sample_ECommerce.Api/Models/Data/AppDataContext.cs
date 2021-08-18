using System;
using Microsoft.EntityFrameworkCore;

namespace Sample_ECommerce.Api.Models
{
  public class AppDataContext : DbContext
  {
      public AppDataContext (DbContextOptions<AppDataContext> op) : base(op){}

      public DbSet<Cliente_Cliente> Clientes { get; set; }

  }
}