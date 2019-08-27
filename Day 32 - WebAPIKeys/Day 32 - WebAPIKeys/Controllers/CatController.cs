using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Day_32___WebAPIKeys.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_32___WebAPIKeys.Controllers
{
    public class CatController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.thecatapi.com"); //TODO - get URI from website
            //^^^ also might be referred to as the request url in the api documentation
            client.DefaultRequestHeaders.Add("x-api-key", "48bc7bd6-427e-4d25-b609-3d04dfdbea9b");
            var response = await client.GetAsync($"v1/breeds");
            //var jsonData = await response.Content.ReadAsStringAsync();
            //jsonData = jsonData.Substring(1, jsonData.Length-1);
            var catObject = await response.Content.ReadAsAsync<List<Cats>>();

            return View(catObject);
        }


    }
}