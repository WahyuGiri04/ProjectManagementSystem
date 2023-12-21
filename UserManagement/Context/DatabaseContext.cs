using Microsoft.EntityFrameworkCore;

namespace UserManagement;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        
    }

    public DbSet<Mt100Load> Mt100Load { get; set; }
}


