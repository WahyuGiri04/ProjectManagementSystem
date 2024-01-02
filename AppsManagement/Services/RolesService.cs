namespace AppsManagement;

public class RolesService
{
    public readonly RolesRepository rolesRepository;

    public RolesService(RolesRepository rolesRepository)
    {
        this.rolesRepository = rolesRepository;
    }

    public async Task<List<Roles>> GetAllRolesAsync()
    {
        return await rolesRepository.GetAllRolesAsync();
    }

}
