namespace Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Prato")]
    public class Prato
    {
        [Key]
        public int PratosID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Descrição")]
        [MaxLength(100, ErrorMessage = "Este campo {0} só pode ter {1} Caracteres.")]
        public string Descricao { get; set; }

        // Conjunto de Produtos para construir estes pratos
        public virtual ICollection<Produtos> Produtos { get; set; }
        public virtual ICollection<Prato> Pratos { get; set; }
    }
}