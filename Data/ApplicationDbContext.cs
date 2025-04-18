

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Data.Configurations;
using Data.Models;
using Microsoft.AspNetCore.Identity;
namespace Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>().Property(o => o.Status).HasMaxLength(10).IsRequired();

            modelBuilder.Entity<Order>().Property(o => o.OrderDate).HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Product>().Property(p => p.Description).HasMaxLength(500).IsRequired();

            modelBuilder.Entity<Product>().Property(p => p.CreatedOn).HasDefaultValueSql("GETDATE()").IsRequired();

            modelBuilder.Entity<Review>().Property(p => p.Comment).IsRequired(required: false);

            modelBuilder.Entity<Review>().Property(p => p.CreatedAt).HasDefaultValueSql("GETDATE()").IsRequired();

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderItems> orderItems { get; set; }
        public DbSet<Review> Reviews { get; set; }

        
       
    }
}
