namespace Backend.Models.Cliente;
// e enfeito por enquanto!!
public class Cliente_CEP
{
    [Key]
    public int ClienteID { get; set; }
    public int CEP { get; set; }
    public string? Endereco { get; set; }
    public string? Numero_residencia { get; set; }
    public string? Complemento { get; set; }
    public string? Estado { get; set; }
    public string? Cidade { get; set; }
    public Cliente_Cliente? Cliente { get; set; }
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
    [DataType(DataType.DateTime)]
    public DateTime ModifiedDate { get; set; }
}