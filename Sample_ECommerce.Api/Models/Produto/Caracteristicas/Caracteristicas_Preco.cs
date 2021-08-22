using System;
using System.ComponentModel.DataAnnotations;

namespace Sample_ECommerce.Api.Models.Produto.Caracteristicas
{
    public class Caracteristicas_Preco
    {
        [Key]
        public int Id { get; set; }
        [Range(0.1,1000000.99)]
        public decimal Preco { get; set; }
        //o valor vai ser em porcentagem!!(ou não)
        [Range(1,20)]
        public uint Desconto { get; set; }
        public Produto_Produto Produto { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }
    }
}
