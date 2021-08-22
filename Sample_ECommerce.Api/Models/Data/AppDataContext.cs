using System;
using Microsoft.EntityFrameworkCore;
using Sample_ECommerce.Api.Models.Produto;
using Sample_ECommerce.Api.Models.Fornecedor;

namespace Sample_ECommerce.Api.Models
{
  public class AppDataContext : DbContext
  {
      public AppDataContext (DbContextOptions<AppDataContext> op) : base(op){}

      public DbSet<Cliente_Cliente> Clientes { get; set; }
      public DbSet<Fornecedor_Fornecedor> Fornecedores { get; set; }
      public DbSet<Produto_Produto> Produtos { get; set; }
      public DbSet<Produto_Console> Consoles { get; set; }

    protected override void OnModelCreating(ModelBuilder mb)
    {
// definir a precição do preco!
    }
  }
}