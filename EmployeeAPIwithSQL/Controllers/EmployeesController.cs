using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeAPIwithSQL.Data;
using EmployeeAPIwithSQL.Models;

namespace EmployeeAPIwithSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDbContext _context;  //db pipe

        public EmployeesController(AppDbContext context)
        {
            _context = context;  //let controller use db
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            return Ok(_context.Employees.ToList());//Tolist() = select * from Employees
        }

        [HttpPost]
        public ActionResult<Employee> AddEmployee(Employee newEmployee)
        {
            _context.Employees.Add(newEmployee);
            _context.SaveChanges();//back to db
            return Ok(newEmployee);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee updateEmployee)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null)
                return NotFound();

            employee.Name = updateEmployee.Name;
            employee.Department = updateEmployee.Department;
            employee.Salary = updateEmployee.Salary;
            _context.SaveChanges();//back to db

            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null)
                return NotFound();

            _context.Employees.Remove(employee);
            _context.SaveChanges();//back to db

            return Ok();
        }
    }
}
