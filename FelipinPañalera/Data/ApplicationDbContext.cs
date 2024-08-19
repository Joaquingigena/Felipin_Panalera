using FelipinPañalera.Models;
using Microsoft.EntityFrameworkCore;

namespace FelipinPañalera.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categoria>().Property(c => c.Nombre).HasMaxLength(50);

            modelBuilder.Entity<Marca>().Property(c => c.Nombre).HasMaxLength(50);

            //Pedido
            modelBuilder.Entity<Pedido>().Property(p => p.Fecha).HasColumnType("date");
            modelBuilder.Entity<Pedido>().Property(p => p.ImporteTotal).HasPrecision(10, 2);

            //Usuario
            //modelBuilder.Entity<Usuario>().Property

            //Producto
            modelBuilder.Entity<Producto>().Property(p => p.Precio).HasPrecision(10, 2);
            modelBuilder.Entity<Producto>().Property(c => c.Nombre).HasMaxLength(50);

            //DetallePedido
            modelBuilder.Entity<DetallePedido>().Property(p => p.PrecioUnitario).HasPrecision(10, 2);

        }

         
        public DbSet<Categoria> Categorias => Set<Categoria>();

        public DbSet<Marca> Marcas => Set<Marca>();

        public DbSet<Pedido> Pedidos => Set<Pedido>();

        public DbSet<Usuario> Usuarios=> Set<Usuario>();
        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<DetallePedido> DetallePedidos=> Set<DetallePedido>();
    }
}
