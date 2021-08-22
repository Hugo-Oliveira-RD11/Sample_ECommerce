using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample_ECommerce.Api.Models.Produto.Caracteristicas;

namespace Sample_ECommerce.Api.Models.Produto
{
    public class Produto_Console
    {
        [Key]
        public int Id { get; set; }
        public Guid rowId { get; set; }
        public string Embalagem { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(200)]
        public string Acessorios { get; set; }
        public int Memoria { get; set; }
        //qual e o tipo da memoria!
        public string MTipo { get; set; }
        public string Processador { get; set; }
        public int PVelocidade { get; set; }
        public int PNucleos { get; set; }
    }
}