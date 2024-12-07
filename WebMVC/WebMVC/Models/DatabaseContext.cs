using Microsoft.EntityFrameworkCore;

namespace WebMVC.Models;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasData(
       new Role() { Id = 1, Name = "Admin", Description = "This is the highest authority", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
       new Role() { Id = 2, Name = "User", Description = "This is the user's permission", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
    }
}
