namespace Data.Controllers.Helps
{
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class MenuContext: DbContext
    {
        #region Construtores da Classe
        public MenuContext()
        {
            Database.EnsureCreated();
        }
        public MenuContext(DbContextOptions<MenuContext> dbContext) : base(dbContext)
        {

        }
        #endregion

        #region Configuração
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            //dbContextOptions.UseSqlServer("");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fazer com que o valor colocado seje um valor decimal
            modelBuilder.Entity<Produtos>()
                .Property(x => x.PrecoUnitario)
                .HasColumnType("decimal(18,2)");

            // Restrição para um valor unico
            modelBuilder.Entity<Produtos>()
              .HasIndex(x => new { x.Descricao, x.PrecoUnitario })
                .IsUnique(true);

            // Evitar que Quando apagar uma iformação se apague tudo...
            var cascadeFKs = modelBuilder.Model
            .G­etEntityTypes()
            .SelectMany(t => t.GetForeignKeys())
            .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Casca­de);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Entity
        public DbSet<MenuDia> MenuDias { get; set; }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Produtos> Produtos { get; set; } 
        #endregion
    }
}
