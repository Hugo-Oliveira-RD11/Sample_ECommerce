namespace Backend.Models.Fornecedor;
public class Fornecedor_Fornecedor
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(80,MinimumLength = 10)] 
    public string? Nome { get; set; }
    [RegularExpression("")]
    [Required]
    public string? Cnpj { get; set; }
    public string? LogoMarca { get; set; }
    [DataType(DataType.Text)]
    [StringLength(450,MinimumLength =50)]
    [Required]
    public string? Descricao { get; set; }
    [EmailAddress]
    [Required]
    public string? Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    [StringLength(80,MinimumLength =10)]
    public string? Senha { get; set; }
    public ICollection<Fornecedor_Cep>? Cep { get; set; }
    public ICollection<Fornecedor_Phone>? Phone { get; set; }
    [Required]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
    [DataType(DataType.DateTime)]
    public DateTime ModifiedDate { get; set; }
}
