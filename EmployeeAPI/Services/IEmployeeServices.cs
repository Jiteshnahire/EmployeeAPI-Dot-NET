using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public interface IEmployeeServices
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee employe);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int id);


    }
}
