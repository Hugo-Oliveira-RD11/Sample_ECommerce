using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sample_ECommerce.Api.Models.Fornecedor
{
    public class Fornecedor_Phone
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string Phone { get; set; }
        [Required]
        public uint TypePhoneNumber { get; set; }
        
        public int FornecedorId { get; set; }

        public Fornecedor_Fornecedor Fornecedor { get; set; }
    }
}
