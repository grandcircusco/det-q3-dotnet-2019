using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_26___ModelValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_26___ModelValidation.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View(new Movie() { });
        }

        [HttpPost]
        public IActionResult DisplayMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                return View(movie);
            }
            else
            {
                return View("Index", movie);
            }
        }
    }
}