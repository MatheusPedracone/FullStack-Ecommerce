using Ecommerce.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasOne(x => x.ProductCategory)
                .WithMany(p => p.Products)
                .HasForeignKey(pc => pc.ProductCategoryId);

            modelBuilder.Entity<Establishment>()
                .HasMany(p => p.Products);


            modelBuilder.Entity<Establishment>()
                .HasOne(p => p.EstablishmentCategory)
                .WithMany(e => e.Market)
                .HasForeignKey(x => x.EstablishmentCategoryId);

            modelBuilder.Entity<Rating>().HasOne(e => e.Establishment).WithMany(r => r.Ratings);
        }
    }
}