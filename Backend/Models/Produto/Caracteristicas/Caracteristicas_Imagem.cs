namespace Backend.Models.Produto.Caracteristicas;
public class Caracteristicas_Imagem
{
   
    [Key]
    public int Id { get; set; }
    public string? LocalFoto1 { get; set; }
    public Produto_Produto? Produto { get; set; } 
}