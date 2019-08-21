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

      
    }
}