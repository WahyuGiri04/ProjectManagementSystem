using Microsoft.AspNetCore.Mvc;

namespace UserManagement;

[Controller]
[Route("[controller]")]
public class RolesController : ControllerBase
{
    private readonly DatabaseContext databaseContext;

    public RolesController(DatabaseContext databaseContext){
        this.databaseContext = databaseContext;
    }

    [HttpPost]
    public IActionResult Insert(Role role)
    {
        databaseContext.Add(role);
        databaseContext.SaveChanges();
        return Ok();
    }

}
