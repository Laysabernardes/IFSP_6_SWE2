using CBTSWE2_TP03.Models;
using Microsoft.EntityFrameworkCore;

//Desenvolvido por Laysa Bernardes e Lucas Lopes

namespace CBTSWE2_TP03.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Descricao).IsRequired().HasMaxLength(500);
                entity.Property(e => e.Preco).IsRequired();
                entity.Property(e => e.QtdEstoque).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
