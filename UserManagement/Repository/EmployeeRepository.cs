using Microsoft.EntityFrameworkCore;

namespace UserManagement;

public class EmployeeRepository
{
    private readonly DatabaseContext databaseContext;

    public EmployeeRepository(DatabaseContext databaseContext){
        this.databaseContext = databaseContext;
    }

    internal async Task<List<Employee>> GetAllEmployeesAsync(){
        return  await databaseContext.Employees.ToListAsync();
    }
}
