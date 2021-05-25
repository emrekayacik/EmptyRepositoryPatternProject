using Microsoft.EntityFrameworkCore;
using Project.Entity.Category;
using Project.Entity.Order;
using Project.Entity.Product;
using Project.Entity.ProductCategory;

namespace Project.Data.Concrete.EF
{
    // dotnet ef migrations --startup-project Project.WebUI\Project.WebUI.csproj --project Project.Data\Project.Data.csproj add UpdateDb001
    // dotnet ef --startup-project Project.WebUI\Project.WebUI.csproj --project Project.Data\Project.Data.csproj database update
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=shopDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(c => new
                {
                    c.CategoryId,
                    c.ProductId
                });
        }
    }
}
