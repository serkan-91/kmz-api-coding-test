using kmz_api_coding_test.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmz_api_coding_test.Persistence.Contexts
{
    public class ECommerceTestDbContext : DbContext
    {
        public ECommerceTestDbContext(DbContextOptions options) : base (options)
        {
        }

        public DbSet<SalesUnit> SalesUnits { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<InventoryProducts> InventoryProducts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductAttribute> ()
        .HasKey (pa => pa.ProductAttributeId);

            modelBuilder.Entity<Inventory> ()
                        .HasKey (s => s.SKU);

            modelBuilder.Entity<Product> ()
  .Property (p => p.Price)
  .HasColumnType ("decimal(18, 2)");
          
        }

    }
}
