using Microsoft.EntityFrameworkCore;
namespace Gourmet.Models
{
    public class GourmetDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public GourmetDbContext(DbContextOptions<GourmetDbContext> options) : base(options)
        {
        }
    }
}
