using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_24___ASP.NET_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_24___ASP.NET_Core.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            return View(new Student() { FirstName="Jim", LastName="Ice Cream", Age=5 });
        }

        [HttpGet]
        public IActionResult StudentForm()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult StudentForm(Student newStudent)
        {
            return RedirectToAction("EnrollStudent", newStudent);
        }

        public IActionResult EnrollStudent(Student student)
        {
            return View(student);
        }


    }
}