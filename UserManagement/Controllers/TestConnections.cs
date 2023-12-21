using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UserManagement;

[ApiController]
[Route("[controller]")]
public class TestConnections : ControllerBase
{

    private readonly DatabaseContext _dbContext;

    public TestConnections(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult TestDatabaseConnection()
    {
        try
        {
            _dbContext.Database.OpenConnection();
            _dbContext.Database.CloseConnection();
            return Ok("Database connection successful.");
        }
        catch (Exception ex)
        {
            return BadRequest($"Database connection error: {ex.Message}");
        }
    }
}
