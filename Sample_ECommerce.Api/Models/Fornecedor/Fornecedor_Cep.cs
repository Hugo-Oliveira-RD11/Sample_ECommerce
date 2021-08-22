using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sample_ECommerce.Api.Models.Fornecedor
{
    public  class Fornecedor_Cep
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string NumeroResidencia { get; set; }
        public string Complemento { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor_Fornecedor Fornecedor { get; set; }
    }
}
