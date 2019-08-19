using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cookies.Models;
using Microsoft.AspNetCore.Http;

namespace Cookies.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //read cookie from Request object
            string karenName = Request.Cookies["KarenKey"];
            return View("Index", karenName);
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string karenName = form["karenName"].ToString();

            //set the key value in the cookie
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Append("KarenKey", karenName, option);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveCookie()
        {
            //Delete the cookie
            Response.Cookies.Delete("KarenKey");
            return View("Index");
        }
    }
}
