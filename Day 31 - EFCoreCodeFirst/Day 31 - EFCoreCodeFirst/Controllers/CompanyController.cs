using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_31___EFCoreCodeFirst.Context;
using Microsoft.AspNetCore.Mvc;

namespace Day_31___EFCoreCodeFirst.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CompanyCFDbContext _context;
        public CompanyController(CompanyCFDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Department> departments = _context.Departments.ToList();
                return View();
        }
    }
}