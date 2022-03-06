namespace Backend.Models.Produto;
public class Produto_Produto
{
    [Key]
    public int ID { get; set; }
    [Required]
    [StringLength(300,MinimumLength =20)]
    public string? Name { get; set; }
    [Required]
    [DataType(DataType.Text)]
    [StringLength(1900,MinimumLength =200)]
    public string? Descricao { get; set; }
    [Required] 
    public int FotoId { get; set; }
    [Required]
    public string? Tag { get; set; }
    [Required]
    [Range(1,100000)]
    public int Estoque { get; set; }
    public ICollection<Caracteristicas_Imagem>? Foto { get; set; }
    public int PrecoId { get; set; }
    public Caracteristicas_Preco? Preco { get; set; }
    public int DimensaoId { get; set; }
    public Caracteristicas_Dimensao? Dimensao { get; set; }
    public int VendasId { get; set; }
    public Vendas_Vendas? Vendas { get; set; }

    [Required]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
    [DataType(DataType.DateTime)]
    public DateTime ModifiedDate { get; set; }
}