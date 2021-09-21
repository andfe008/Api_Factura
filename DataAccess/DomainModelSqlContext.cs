using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Core.Models;

namespace DataAccessSqliteProvider
{
    public class DomainModelSqlContext : DbContext
    {
        public DomainModelSqlContext(DbContextOptions<DomainModelSqlContext> options) : base(options)
        { }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Detalle_Venta> Detalle_Venta { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<ModoPago> ModoPago { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Venta> Venta { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            return base.SaveChanges();
        }

        private void updateUpdatedProperty<T>() where T : class
        {
            var modifiedSourceInfo =
                ChangeTracker.Entries<T>()
                    .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

        }
    }
}