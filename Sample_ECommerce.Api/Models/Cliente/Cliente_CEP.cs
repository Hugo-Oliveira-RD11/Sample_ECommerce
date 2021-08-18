using System.ComponentModel.DataAnnotations;

namespace Sample_ECommerce.Api.Models
{
    // e enfeito por enquanto!!
    public class Cliente_CEP
    {
        [Key]
        public int ClienteID { get; set; }
        public int CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero_residencia { get; set; }
        public string Complemento { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public Cliente_Cliente Cliente { get; set; }
    }
}