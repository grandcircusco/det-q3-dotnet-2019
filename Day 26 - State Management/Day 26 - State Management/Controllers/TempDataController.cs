using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Day_26___State_Management.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult First()
        {
            TempData["SusanKey"] = "SusanValue";
            return View();
        }

        public IActionResult Second()
        {
            var susan = TempData["SusanKey"] ?? null;
            return View();
        }

        public IActionResult Third()
        {
            var susan = TempData["SusanKey"] ?? null;
            return View();
        }
    }
}