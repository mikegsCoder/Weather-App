using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherApp.Core.Contracts;
using WeatherApp.Web.Models;

namespace WeatherApp.Web.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _service;
        private readonly ILogger _logger;

        public WeatherController(IWeatherService service, ILogger<WeatherController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> WeatherInfo(string cityName)
        {
            if (string.IsNullOrEmpty(cityName)) return View("Index");

            try
            {
                var info = await _service.GetWeatherInfoAsync(cityName);

                ViewBag.GeneralInfo = info.Item1;
                ViewBag.InfoCards = info.Item2;

                return null; // to implement view
            }
            catch (Exception ex)
            {
                _logger.LogError(string.Concat(nameof(WeatherController), " - ", nameof(WeatherInfo), ": ", ex.Message), ex);

                return RedirectToAction("NotFound", new { cityName });
            }
        }

        [HttpGet]
        public IActionResult NotFound(string cityName)
        {
            ViewBag.CityName = cityName;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
