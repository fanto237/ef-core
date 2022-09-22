using ef_core.Models;
using Microsoft.EntityFrameworkCore;

namespace ef_core.Data;

public class DataContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
    private readonly string _connectionString = "Server=localhost,1433;Database=OrderDb;Uid=sa;Pwd=fanto237(!);";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }
}