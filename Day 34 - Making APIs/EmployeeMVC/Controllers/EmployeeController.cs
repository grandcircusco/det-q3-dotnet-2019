using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EmployeeMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44389");

            var response = await client.GetAsync("api/company");
            var result = await response.Content.ReadAsAsync<List<Employee>>();
            return View(result);
        }
    }
}