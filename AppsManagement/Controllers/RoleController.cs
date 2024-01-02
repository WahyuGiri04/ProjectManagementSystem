using Microsoft.AspNetCore.Mvc;

namespace AppsManagement;

[ApiController]
[Route("[controller]")]
public class RoleController
{
    private readonly RolesService rolesService;

    public RoleController(RolesService rolesService){
        this.rolesService = rolesService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Roles>>> GetAllRolesAsync(){
        return await rolesService.GetAllRolesAsync();
    }

}
