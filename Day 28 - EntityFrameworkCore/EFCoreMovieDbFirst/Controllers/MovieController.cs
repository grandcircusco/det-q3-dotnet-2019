using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreMovieDbFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreMovieDbFirst.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieDbContext _context;
        
        public MovieController(MovieDbContext context)
        {
            _context = context;
        }

        //Index will list out the movies in our Database
        public IActionResult Index()
        {
            List<Movie> movieList = _context.Movie.ToList();
            return View(movieList);
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie newMovie)
        {
            if (ModelState.IsValid)
            {
                _context.Movie.Add(newMovie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


        public IActionResult DeleteMovie(int Id)
        {
            Movie found = _context.Movie.Find(Id);
            if(found != null)
            {
                _context.Movie.Remove(found);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
      
    }
}