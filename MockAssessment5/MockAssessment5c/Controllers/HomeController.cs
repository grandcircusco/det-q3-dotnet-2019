using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockAssessment5c.Models;

namespace MockAssessment5c.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAge()
        {
            ViewBag.NameAndAge = "Hey, what's your name and how old are you?";

            return View();
        }

        public IActionResult Result(int Age, string UserName)
        {
            if(Age >= 18)
            {
                ViewData["CanVote"] = $"{UserName} can Vote";
            }

            if(Age >= 21)
            {
                ViewData["CanDrink"] = $"{UserName} can Drink";
            }

            if(Age >= 25)
            {
                ViewData["CanRent"] = $"{UserName} can Drive";
            }

            if(Age < 18)
            {
                ViewData["TooYoung"] = $"{UserName} is still in high school.";
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
