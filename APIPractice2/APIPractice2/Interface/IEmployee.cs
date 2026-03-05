using APIPractice2.Models;

namespace APIPractice2.Interface
{
    public interface IEmployee
    {
        ICollection<Employee> GetEmployees();
        Employee GetEmployee(int id);
    }
}
