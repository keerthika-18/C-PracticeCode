using APIPractice2.Data;
using APIPractice2.Repository;
using Microsoft.AspNetCore.Mvc;
using APIPractice2.Models;
using APIPractice2.Interface;
using APIPractice2.Dto;

namespace APIPractice2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController:ControllerBase
    {
        //[HttpGet]
        //[ProducesResponseType]
        private readonly IDepartment _departmentRepository;
        public DepartmentController(IDepartment departmentRepository)
        {
            _departmentRepository = departmentRepository;
            
        }

        [HttpGet]
        [ProducesResponseType(200,Type =typeof(IEnumerable<DepartmentDto>))]
        public IActionResult GetDepartments()
        {
            var departments = _departmentRepository.GetDepartments().Select(d=> new DepartmentDto
            {
                DeptID = d.DeptID,
                DeptName = d.DeptName,
                EmpID = d.EmpID
            }).ToList();
            return Ok(departments);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(200, Type=typeof(DepartmentDto))]
        public IActionResult GetDepartmentById(int id)
        {
            var department = _departmentRepository.GetDepartmentById(id);
            if (department == null)
            {
                return NotFound();
            }
            var departmentDto = new DepartmentDto
            {
                DeptID = department.DeptID,
                DeptName = department.DeptName,
                EmpID = department.EmpID

            };
            return Ok(departmentDto);
        }

    }
}
