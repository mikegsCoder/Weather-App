using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WeatherApp.Web.Controllers
{
    public class WeatherController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> WeatherInfo(string cityName)
        {
            if (string.IsNullOrEmpty(cityName)) return View("Index");

            // to implement ...
            return null;
        }
    }
}
