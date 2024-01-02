using Microsoft.EntityFrameworkCore;

namespace AppsManagement;

public class RolesRepository
{
    private readonly DatabaseContext databaseContext;

    public RolesRepository(DatabaseContext databaseContext){
        this.databaseContext = databaseContext;
    }

    internal async Task<List<Roles>> GetAllRolesAsync(){
        return  await databaseContext.Roles.ToListAsync();
    }

}
