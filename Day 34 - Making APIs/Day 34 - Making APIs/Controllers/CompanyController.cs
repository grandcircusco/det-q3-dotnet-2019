using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_34___Making_APIs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day_34___Making_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyDbContext _context;

        public CompanyController(CompanyDbContext context)
        {
            _context = context;

            if (_context.Employee.Count() == 0)
            {
                _context.Employee.Add(new Employee { FirstName = "Grant", LastName = "Chirpus", StartDate = DateTime.Parse("07/15/2019") });
            }
        }

        //GET: api/Company/Employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            var employeeList = await _context.Employee.ToListAsync();
            return employeeList;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployeeById(int id)
        {
            var found = await _context.Employee.FindAsync(id);

            if (found == null)
            {
                return NotFound();
            }
            return found;
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            _context.Employee.Add(employee);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.EmployeeId }, employee);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> PutEmployee(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            if(employee == null)
            {
                return NotFound();
            }

            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}