using Microsoft.EntityFrameworkCore;
using SimpleOnlineStore.Models;

namespace SimpleOnlineStore.Database_Connection
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("User", "Simple_Online_Store");
            modelBuilder.Entity<Product>().ToTable("Product", "Simple_Online_Store");
            modelBuilder.Entity<Category>().ToTable("Category", "Simple_Online_Store");
            modelBuilder.Entity<Order>().ToTable("Order", "Simple_Online_Store");
            modelBuilder.Entity<OrderItem>().ToTable("OrderItem", "Simple_Online_Store");
            modelBuilder.Entity<Cart>().ToTable("Cart", "Simple_Online_Store");
            modelBuilder.Entity<CartItem>().ToTable("CartItem", "Simple_Online_Store");
            modelBuilder.Entity<Payment>().ToTable("Payment", "Simple_Online_Store");
            modelBuilder.Entity<Review>().ToTable("Review", "Simple_Online_Store");
        }

        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Categorie { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Review> Review { get; set; }
    }
}
