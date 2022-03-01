namespace Backend.Models.Produto.Caracteristicas
{
    public class Caracteristicas_Preco
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(0.1,1000000.99)]
        public decimal Preco { get; set; }
        [Range(1,20)]
        public uint Desconto { get; set; }
        [Required]
        public Produto_Produto? Produto { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }
    }
}
