namespace template.core;

using Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions options):base(options)
    {
    }
    public DbSet<User> Users => this.Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new List<User>()
            {
                new()
                {
                    Id = 1,
                    Name = "John"
                },
                new()
                {
                    Id = 2,
                    Name = "Admin"
                },
                new()
                {
                    Id = 3,
                    Name = "Collins"
                },
                new()
                {
                    Id = 4,
                    Name = "South"
                },
            });
    }
}
