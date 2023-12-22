using Microsoft.EntityFrameworkCore;

namespace UserManagement;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        
    }

    public DbSet<Role> Role { get; set; }
}


