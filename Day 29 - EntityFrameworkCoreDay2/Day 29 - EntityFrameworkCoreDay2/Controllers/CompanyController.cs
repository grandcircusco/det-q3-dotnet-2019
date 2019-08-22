using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_29___EntityFrameworkCoreDay2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_29___EntityFrameworkCoreDay2.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CompanyDbContext _context;

        public CompanyController(CompanyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Employee> employeeList = _context.Employee.ToList();
            return View(employeeList);
        }

        public IActionResult AddNewEmployee()
        {
            List<Department> departmentList = _context.Department.ToList();
            return View(departmentList);
        }

        [HttpPost]
        public IActionResult AddNewEmployee(Employee newEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Employee.Add(newEmployee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult RemoveEmployee(int Id)
        {
            Employee found = _context.Employee.Find(Id);
            if(found != null)
            {
                _context.Employee.Remove(found);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}