using APIPractice2.Models;

namespace APIPractice2.Interface
{
    public interface IDepartment
    {
        ICollection<Department> GetDepartments();
        Department GetDepartmentById(int id);
    }
}
