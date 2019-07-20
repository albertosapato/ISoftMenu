﻿namespace Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Menu")]
    public class Menus
    {
        //[Key]
        public int MenuID { get; set; }
        public DateTime Data { get; set; }
        public ICollection<Prato> Pratos { get; set; }
    }
}
