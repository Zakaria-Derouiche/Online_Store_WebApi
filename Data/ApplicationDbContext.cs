

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Data.Configurations;
using Data.Models;
namespace Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ProductConfigurations().Configure(modelBuilder.Entity<Product>());

            new OrderConfigurations().Configure(modelBuilder.Entity<Order>());

            new OrderItemsConfigurations().Configure(modelBuilder.Entity<OrderItems>());

            new UserConfigurations().Configure(modelBuilder.Entity<User>());

            new CategoryConfigurations().Configure(modelBuilder.Entity<Category>());

            new ReviewConfigurations().Configure(modelBuilder.Entity<Review>());
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderItems> orderItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
       
    }
}
