using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Day_31___Web_APIs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_31___Web_APIs.Controllers
{
    public class JokeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://api.icndb.com");

            var response = await client.GetAsync("jokes/random");
            var joke = await response.Content.ReadAsAsync<Joke>();
            return View(joke);
        }
    }
}