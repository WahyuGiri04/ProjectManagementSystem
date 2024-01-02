using Microsoft.AspNetCore.Mvc;

namespace UserManagement;

[Controller]
[Route("[controller]")]
public class RolesController : ControllerBase
{
    private readonly RolesRepository rolesRepository;

    public RolesController(RolesRepository rolesRepository)
    {
        this.rolesRepository = rolesRepository;
    }

    [HttpPost]
    public IActionResult Insert(Role role)
    {
        var result = rolesRepository.Insert(role);
        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult<List<Role>>> GetAllRoles()
    {
        var roles = await rolesRepository.GetAllRolesAsync();
        return Ok(roles);
    }

}
