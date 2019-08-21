using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_28___EntityFrameworkCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_28___EntityFrameworkCore.Controllers
{
    public class NorthwindController : Controller
    {
        private readonly NorthwindContext _context;

        public NorthwindController(NorthwindContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}