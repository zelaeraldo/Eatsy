using Eatsy1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eatsy1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cart>? Cart { get; set; }
        public DbSet<CartItem>? CartItem { get; set; }
        public DbSet<Customer>? Customer { get; set; }
        public DbSet<DeliveryDriver>? DeliveryDriver { get; set; }
        public DbSet<Order>? Order { get; set; }
        public DbSet<OrderDetail>? OrderDetail { get; set; }
        public DbSet<Payment>? Payment { get; set; }
        public DbSet<Product>? Product { get; set; }
        public DbSet<Restaurant>? Restaurant { get; set; }
        public DbSet<Review>? Review { get; set; }
    }
}
