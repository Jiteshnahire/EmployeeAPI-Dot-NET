using EmployeeAPI.Data;
using EmployeeAPI.Models;

namespace EmployeeAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;
        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }
        public int AddEmployee(Employee employe)
        {
            _context.Employees.Add(employe);
            return _context.SaveChanges();
        }

        public int DeleteEmployee(int id)
        {
            int res = 0;
            var product = _context.Employees.Where(x => x.id == id).FirstOrDefault();
            if (product != null)
            {
                _context.Employees.Remove(product);
                res = _context.SaveChanges();
            }
            return res;
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            var Employee = _context.Employees.Where(x => x.id == id).FirstOrDefault();
            return Employee;
        }

        public int UpdateEmployee(Employee product)
        {
            int res = 0;
            var empl = _context.Employees.Where(x => x.id == product.id).FirstOrDefault();
            if (empl != null)
            {
                empl.name = product.name;
                empl.designation = product.designation;
                empl.age = product.age;
                res = _context.SaveChanges();
            }
            return res;
        }
    }
}


