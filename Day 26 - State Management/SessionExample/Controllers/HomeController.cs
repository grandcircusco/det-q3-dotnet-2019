using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SessionExample.Models;

namespace SessionExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SaveUserName(string UserName)
        {
            HttpContext.Session.SetString("NameSession", UserName);
            return View("Index");
        }


    }
}
