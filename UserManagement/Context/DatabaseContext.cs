using Microsoft.EntityFrameworkCore;

namespace UserManagement;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        
    }

    public virtual DbSet<Employee> Employees { get; set; }
}


