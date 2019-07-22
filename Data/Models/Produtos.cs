using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    [Table("Produtos")]
    public class Produtos
    {
        [Key]
        public int ProdutosID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Descrição")]
        [MaxLength(200, ErrorMessage = "Este campo {0} só pode ter {1} Caracteres.")]        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "P. Unitário")]
        public decimal PrecoUnitario { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Percentagem")]
        [Range(0, 100, ErrorMessage ="Desculpe mais este valor vária apenas entre {0} até {1}")]
        public int Estrelas { get; set; }

        // Chave estrangeira
        public virtual Prato Prato { get; set; }
    }
}
