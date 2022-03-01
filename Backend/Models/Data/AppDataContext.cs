namespace Backend.Models;
public class AppDataContext : DbContext
{
    public AppDataContext (DbContextOptions<AppDataContext> op) : base(op){}

    public DbSet<Cliente_Cliente> Clientes { get; set; } =null!;
    public DbSet<Fornecedor_Fornecedor> Fornecedores { get; set; } =null!;
    public DbSet<Produto_Produto> Produtos { get; set; } =null!;
  protected override void OnModelCreating(ModelBuilder mb)
  {
  //definir a precição do preco!
  }
}