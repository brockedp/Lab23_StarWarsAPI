using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab23_StarWarsAPI.Models;
using System.Net.Http;
using Microsoft.IdentityModel.Protocols;
using NLog.Internal;

namespace Lab23_StarWarsAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public static HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co");
            return client;

        }
        public async Task<IActionResult> GetPersonbyId(int characterId)
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"api/people/{characterId}/");
            var character = await response.Content.ReadAsAsync<Characters>();
            return View(character);

        }
        public async Task<IActionResult> GetPlanetbyId(int planetId)
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"api/planets/{planetId}/");
            var planet = await response.Content.ReadAsAsync<Planets>();
            return View(planet);

        }


    }
}
