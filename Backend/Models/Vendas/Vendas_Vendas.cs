namespace Backend.Models.Vendas;
public class Vendas_Vendas
{
    public Guid Id { get; set; }
    [Required]
    public int ClienteId { get; set; }
    [Required]
    public Cliente_Cliente? Cliente { get; set; }
    [Required]
    public ICollection<Produto_Produto>? Produto { get; set; }
    [Required]
    public ICollection<FornecedorVendas_FornecedorVendas>? FornecedorVendas { get; set; }
}
