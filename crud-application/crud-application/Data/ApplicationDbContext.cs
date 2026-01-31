using crud_application.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_application.Data;

public class ApplicationDbContext : DbContext
{
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Optional: enforce table name lowercase
        modelBuilder.Entity<Customer>().ToTable("Customers");

        base.OnModelCreating(modelBuilder);
    }

}