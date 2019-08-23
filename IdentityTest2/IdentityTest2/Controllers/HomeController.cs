using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityTest2.Models;
using System.Security.Claims;

namespace IdentityTest2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IdentityDbContext _context;

        public HomeController(IdentityDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(LibraryBooks newBook)
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value; ;
            newBook.UserId = id;
            if (ModelState.IsValid)
            {
                _context.LibraryBooks.Add(newBook);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


    }
}
