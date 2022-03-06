namespace Backend.Models.FornecedorVendas;
public class FornecedorVendas_FornecedorVendas
{
    public int Id { get; set; }
    public int VendasId { get; set; }
    public Vendas_Vendas? Vendas { get; set; }
    public int FornecedorId { get; set; }
    public Fornecedor_Fornecedor? Fornecedor { get; set; }
}
