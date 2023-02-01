using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Menu;
using WebApplication1.Models.Shop;

namespace WebApplication1.Data
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Item> Menu { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<User> Users { get; set; }
        public ShopDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
