using Day_33___WebAPIsDay3.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Day_33___WebAPIsDay3.Controllers
{
    public class CatAPIMethods
    {
        public static HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.thecatapi.com");
            var apiKey = ConfigurationManager.AppSettings["CatAPIKey"];
            client.DefaultRequestHeaders.Add("x-api-key", apiKey);
            return client;
        }

        public static async Task<List<CatBreed>> CatBreeds()
        {
            var client = GetHttpClient();

            var response = await client.GetAsync("v1/breeds");
            var catBreeds = await response.Content.ReadAsAsync<List<CatBreed>>();
            return catBreeds;
        }

        public static async Task<BreedImage> GetBreedImages()
        {
            var client = GetHttpClient();

            var response = await client.GetAsync("v1/images/search?breed_id=beng");
            var catImages = await response.Content.ReadAsAsync<List<BreedImage>>();
            return catImages[0];
        }
    }
}
