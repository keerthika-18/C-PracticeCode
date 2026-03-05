using APIPractice2.Interface;
using APIPractice2.Models;
using APIPractice2.Repository;
using Microsoft.AspNetCore.Mvc;
using APIPractice2.Data;
using APIPractice2.Dto;
using Microsoft.EntityFrameworkCore;

namespace APIPractice2.Controllers
{
    [Route("api/[controller]")]//controller=Employee 
    [ApiController]//its show for the model validation and provide 400 in automatic
    public class EmployeeController:ControllerBase
    {
        private readonly IEmployee _employeeRepository; //to avoid seeing the implementation we use the Interface than the implementation of the repository
        public EmployeeController(IEmployee employeeRepository)
        {
            _employeeRepository = employeeRepository;//assignment done in the constructor as constructor injection
           
        }
        [HttpGet]
        [ProducesResponseType(200,Type=typeof(IEnumerable<EmployeeDto>))]//to avoid showingthe unimportant datas to the user
        public IActionResult GetEmployees()
        {
            var employees = _employeeRepository.GetEmployees().Select(e => new EmployeeDto
            {
                EmpID = e.EmpID,
                EmpName=e.EmpName,
               
            }).ToList();//mapping 
            return Ok(employees);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(200,Type=typeof(EmployeeDto))]
        public IActionResult GetEmployee(int id)
        {
            var employee = _employeeRepository.GetEmployee(id);
            if (employee == null)
                return NotFound();
            var employeeDto = new EmployeeDto
            {
                EmpID = employee.EmpID,
                EmpName=employee.EmpName,
            };
            return Ok(employeeDto);
        }
    }
}
