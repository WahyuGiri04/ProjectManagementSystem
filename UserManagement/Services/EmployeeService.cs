namespace UserManagement;

public class EmployeeService
{
    private readonly EmployeeRepository employeeRepository;

    public EmployeeService(EmployeeRepository employeeRepository){
        this.employeeRepository = employeeRepository;
    }

    public async Task<List<Employee>> GetAllEmployeesAsync(){
        return await employeeRepository.GetAllEmployeesAsync();
    }
}
