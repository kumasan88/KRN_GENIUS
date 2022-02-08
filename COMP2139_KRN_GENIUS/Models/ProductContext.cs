using Microsoft.EntityFrameworkCore;

namespace COMP2139_KRN_GENIUS.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; } //collection of objects created from Products entity
    
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().HasData(
        //        new Product { productId =1, Code = }
        //        );
        //}
    }
}
