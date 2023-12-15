namespace template.core;

using Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions options):base(options)
    {
    }
    public DbSet<User> Users => this.Set<User>();
}
