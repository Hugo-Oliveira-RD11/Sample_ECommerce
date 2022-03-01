namespace Backend.Models.Produto.Caracteristicas;
public class Caracteristicas_Dimensao
{
  [Key]
  public int Id { get; set; }
  [Range(0.1,200.99)]
  [Required]
  public int Altura { get; set; }
  [Range(0.1,1000.99)]
  [Required]
  public int Comprimento { get; set; }
  [Required]
  [Range(0.1,1000.99)]
  public int Largura { get; set; }
  [Range(0.1,1000.99)]
  [Required]
  public int peso { get; set; }
  public Produto_Produto? Produto { get; set; }
  [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
  [DataType(DataType.DateTime)]
  public DateTime ModifiedDate { get; set; }

}