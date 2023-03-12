using DependencyInjenction.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DependencyInjenction.API.Context
{
    public class ContextApi : DbContext
    {
        public ContextApi(DbContextOptions<ContextApi> options)
        : base(options)
        {
        }
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Pedido>? Pedido { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Cliente>()
                .HasKey(e => e.ClienteId);
            modelBuilder.Entity<Pedido>()
                .HasKey(e => e.PedidoId);
               
        }
    }
}
