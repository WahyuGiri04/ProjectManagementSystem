using Microsoft.EntityFrameworkCore;

namespace AppsManagement;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {

    }

    public virtual DbSet<Roles> Roles { get; set; }
}
