using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Context;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    public class UserController : Controller
    {
        private readonly UsersPetsCarsDbContext _context;
        public UserController(UsersPetsCarsDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Users> users = _context.Users.ToList();
            return View(users);
        }

        public IActionResult AddUser()
        {
            return View(new Users());
        }

        [HttpPost]
        public IActionResult AddUser(Users users)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(users);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(users);
        }

        public IActionResult DeleteUser(int id)
        {
            Users found = _context.Users.Find(id);
            if(found != null)
            {
                _context.Users.Remove(found);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult UpdateUser(int id)
        {
            Users found = _context.Users.Find(id);
            if (found != null)
            {
                return View(found);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateUser(Users newUser)
        {
            Users oldUser = _context.Users.Find(newUser.UserId);
            if(ModelState.IsValid && oldUser != null)
            {
                oldUser.FirstName = newUser.FirstName;
                oldUser.LastName = newUser.LastName;
                oldUser.DateOfBirth = newUser.DateOfBirth;
                oldUser.City = newUser.City;

                _context.Entry(oldUser).State = Microsoft.EntityFrameworkCore
                    .EntityState.Modified;
                _context.Update(oldUser);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oldUser);
        }
    }
}