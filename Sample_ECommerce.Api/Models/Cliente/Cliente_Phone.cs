using System;
using System.ComponentModel.DataAnnotations;

namespace Sample_ECommerce.Api.Models
{
	public class Cliente_Phone
	{
        [Key]
		public int ClienteID { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }
        [Required]
        // se for 1 e celular,
        // se for 2 e o segundo celular,
        // se for 3 e celular adicionado pelo cep(recebimento!)
        // se for 4 e telefone fixo
        public uint TypePhoneNumber { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }

        [Required]
        public Cliente_Cliente Cliente { get; set; }
    }
}