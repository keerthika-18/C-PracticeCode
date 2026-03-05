using APIPractice2.Interface;
using APIPractice2.Models;
using APIPractice2.Data;
namespace APIPractice2.Repository
{
    public class DepartmentRepository : IDepartment
    {
        private readonly DataContext _context;
        public DepartmentRepository(DataContext context)
        {
            _context = context;
        }
        public Department GetDepartmentById(int id)
        {
            return _context.Department.Find(id);
        }

        public ICollection<Department> GetDepartments()
        {
           return _context.Department.ToList();
        }
    }
}
