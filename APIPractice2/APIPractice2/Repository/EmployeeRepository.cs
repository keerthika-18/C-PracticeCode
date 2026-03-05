using APIPractice2.Data;
using APIPractice2.Interface;
using APIPractice2.Models;
using Microsoft.EntityFrameworkCore;

namespace APIPractice2.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public Employee GetEmployee(int id)
        {
          return _context.Employee.Include(e=>e.Department).FirstOrDefault(e=>e.EmpID==id);
        }

        public ICollection<Employee> GetEmployees()
        {
            return _context.Employee.ToList();
        }
    }
}
