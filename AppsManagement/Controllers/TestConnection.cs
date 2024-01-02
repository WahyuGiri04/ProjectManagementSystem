using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppsManagement;

[ApiController]
[Route("[controller]")]
public class TestConnection : ControllerBase
{
    private readonly DatabaseContext _dbContext;

    public TestConnection(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult TestDatabaseConnection()
    {
        try{
            _dbContext.Database.OpenConnection();
            _dbContext.Database.CloseConnection();
            return Ok("Database connection successful.");
        }
        catch(Exception ex){
            return BadRequest($"Database connection error: {ex.Message}");
        }
    }
}
