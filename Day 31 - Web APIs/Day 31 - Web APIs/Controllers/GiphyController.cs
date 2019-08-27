using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Day_31___Web_APIs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_31___Web_APIs.Controllers
{
    public class GiphyController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();

            //TODO - locate Uri from Giphy documentation
            client.BaseAddress = new Uri("https://api.giphy.com/");

            string query = "grandcircusco";
            //TODO - locate queries from Giphy documentation
            var response = await client.GetAsync($"v1/gifs/search?api_key=LVYV746VT4FAzRTbod3S4NGBxGSLZyx1&q={query}&limit=25&offset=0&rating=G&lang=en");
            var giphy = await response.Content.ReadAsAsync<Rootobject>();
            return View(giphy);
        }
    }
}