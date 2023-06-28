using EmployeeAPI.Models;
using EmployeeAPI.Repositories;

namespace EmployeeAPI.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeServices(IEmployeeRepository repo)
        {
            _repo = repo;
        }
        public int AddEmployee(Employee empl)
        {
            return _repo.AddEmployee(empl);
        }

        public int DeleteEmployee(int id)
        {
            return (_repo.DeleteEmployee(id));
        }

        public List<Employee> GetAllEmployees()
        {
            return _repo.GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return _repo.GetEmployeeById(id);
        }

        public int UpdateEmployee(Employee employee)
        {
            return _repo.UpdateEmployee(employee);
        }
    }
}
