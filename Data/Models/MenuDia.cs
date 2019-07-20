using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    [Table("MenuDia")]
    public class MenuDia
    {
        //[Key]
        public int MenuDiaID { get; set; }
        public DateTime dataHora { get; set; }

        // Chave Estrangeira
        public virtual Prato Prato { get; set; }
    }
}
