namespace Data.Controllers.Helps
{
    using Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class MenuContext: DbContext
    {
        public MenuContext(DbContextOptions dbContext)
        {

        }
        public MenuContext()
        {

        }
        public DbSet<MenuDia> MenuDias { get; set; }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Produtos> Produtos{ get; set; }
    }
}
