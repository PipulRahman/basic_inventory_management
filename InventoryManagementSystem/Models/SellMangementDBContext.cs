using Microsoft.EntityFrameworkCore;
using InventoryManagementSystem.ViewModels;

namespace InventoryManagementSystem.Models
{
    public class SellManagementDBContext : DbContext
    {
        public SellManagementDBContext(DbContextOptions<SellManagementDBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public DbSet<InventoryManagementSystem.ViewModels.MyClass> MyClass { get; set; }
    }
}
