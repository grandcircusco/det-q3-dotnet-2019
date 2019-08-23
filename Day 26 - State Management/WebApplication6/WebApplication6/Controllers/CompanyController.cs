using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
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
            return View(_context.Employee.ToList());
        }

        public IActionResult DisplayEmployee(int Id)
        {
            Employee employee = _context.Employee.Find(Id);
            return View(employee);
        }
    }
}