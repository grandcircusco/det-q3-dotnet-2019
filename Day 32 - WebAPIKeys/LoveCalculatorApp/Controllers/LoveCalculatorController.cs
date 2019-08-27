using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using LoveCalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoveCalculatorApp.Controllers
{
    public class LoveCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoveApiResult(string Fname, string Sname)
        {
            var result = GetLoveCalcResults(Fname, Sname);
            return View(result);
        }

        public async Task<LoveCalculator> GetLoveCalcResults(string Fname, string Sname)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://love-calculator.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "love-calculator.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "Afnzr4pk72mshUNIhIIYfjrpdY8Zp1qV7OKjsncttkrAgYLSK7");

            var response = await client.GetAsync($"getPercentage?fname={Fname}&sname={Sname}");

            var result = await response.Content.ReadAsAsync<LoveCalculator>();

            return result;
        }
    }
}