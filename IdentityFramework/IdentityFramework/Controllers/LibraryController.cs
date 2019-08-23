using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityFramework.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityFramework.Controllers
{
    [Authorize]
    public class LibraryController : Controller
    {
        private readonly IdentityFrameworkTestDbContext _context;

        public LibraryController(IdentityFrameworkTestDbContext context)
        {
            _context = context;
        }

        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(LibraryBooks newBook)
        {
            AspNetUsers thisUser = _context.AspNetUsers.Where(u => u.UserName == User.Identity.Name).First();
            newBook.UserId = thisUser.Id;
            _context.LibraryBooks.Add(newBook);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}