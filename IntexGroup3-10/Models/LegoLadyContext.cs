using Microsoft.EntityFrameworkCore;

namespace IntexGroup3_10.Models
{
    public class LegoLadyContext: DbContext
    {
        public LegoLadyContext (DbContextOptions<LegoLadyContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<HomeRecommendation> HomeRecommendations { get; set; }
    }
}
