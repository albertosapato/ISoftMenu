using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    [Table("Menu")]
    public class Produtos
    {
      //[Key]
        public int ProdutosID { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public bool Validade { get; set; }
        public int Estrelas { get; set; }

        // Chave estrangeira
        public virtual Prato Prato { get; set; }
    }
}
