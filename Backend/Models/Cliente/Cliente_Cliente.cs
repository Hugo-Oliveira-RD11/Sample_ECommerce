namespace Backend.Models.Cliente;

public class Cliente_Cliente
{
    [Key]
    public int Id { get; set; }

    public Guid Rowguid { get; set; }

    [Display(Name = "Nome")]
    [Required]
    public string? FistName { get; set; }

    [Display(Name = "Sobrenome")]
    [Required]
    public string? LastName { get; set; }
    
    [Display(Name = "Gênero")]
    public string? Gender { get; set; }

    [Required]
    [RegularExpression(@"([0-9]{3})-?\.?([0-9]{3})-?\.?([0-9]{3})-?\.?([0-9]{2})")]
    [StringLength(9, MinimumLength = 9)]
    public string? CPF { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    
    [DataType(DataType.Password)]
    [Required]
    [Display(Name = "Senha")]
    public int Password { get; set; }

    [DataType(DataType.Text)]
    public string? MyPhoto { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
    [DataType(DataType.DateTime)]
    public DateTime ModifiedDate { get; set; }

    public ICollection<Cliente_Phone>? Phone { get; set; }
    public ICollection<Cliente_CEP>? CEP { get; set; }
    public ICollection<Cliente_Cartao>? Cartao { get; set; }
}