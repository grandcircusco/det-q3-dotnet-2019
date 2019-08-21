using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockAssessment5.Models;

namespace MockAssessment5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult Result(int num1, int num2, string operation)
        {
            if(operation == "Plus")
            {
                ViewBag.Result = num1 + num2;
            }
            else if(operation == "Minus")
            {
                ViewBag.Result = num1 - num2;
            }
            else if(operation == "Multiply")
            {
                ViewBag.Result = num1 * num2;
            }
            else
            {
                ViewBag.Result = num1 / num2;
            }

            ViewBag.Operation = operation;
            return View();
        }
    }
}
