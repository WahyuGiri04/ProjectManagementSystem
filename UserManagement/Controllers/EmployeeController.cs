using Microsoft.AspNetCore.Mvc;

namespace UserManagement;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController
{
    private readonly EmployeeService employeeService;

    public EmployeeController(EmployeeService employeeService){
        this.employeeService = employeeService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Employee>>> GetAllEmployeesAsync(){
        return await employeeService.GetAllEmployeesAsync();
    }
}
