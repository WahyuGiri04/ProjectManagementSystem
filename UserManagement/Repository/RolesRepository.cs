using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UserManagement;

public class RolesRepository
{
    private readonly DatabaseContext databaseContext;

    public RolesRepository(DatabaseContext databaseContext)
    {
        this.databaseContext = databaseContext;
    }

    public async Task<List<Role>> GetAllRolesAsync()
    {
        return await databaseContext.Roles.ToListAsync();
    }

    public IActionResult Insert(Role role)
    {
        databaseContext.Add(role);
        databaseContext.SaveChanges();
        return new OkResult();
    }
}
