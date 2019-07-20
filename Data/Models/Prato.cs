namespace Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Prato")]
    public class Prato
    {
        //[Key]
        public int PratosID { get; set; }
        public string Descricao { get; set; }

        // Conjunto de Produtos para construir estes pratos
        public virtual ICollection<Produtos> Produtos { get; set; }
        public virtual ICollection<Prato> Pratos { get; set; }
    }
}