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
      
        [HttpGet]
        public IActionResult UpdateMovie(int Id)
        {
            Movie found = _context.Movie.Find(Id);
            if(found != null)
            {
                return View(found);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult UpdateMovie(Movie updatedMovie)
        {
            Movie found = _context.Movie.Find(updatedMovie.MovieId);

            if (ModelState.IsValid && found != null)
            {
                found.MovieId = updatedMovie.MovieId;
                found.Title = updatedMovie.Title;
                found.ReleaseYear = updatedMovie.ReleaseYear;

                _context.Entry(found).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(found);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("UpdateMovie", found);
        }

    }
}