using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.MAUI.DataContexts;
using System.Globalization;
using WeatherApp.Core.Contracts;

namespace WeatherApp.MAUI.Controllers
{
    public class WeatherController
    {
        private readonly MainPageContext context;
        private readonly IWeatherService weatherService;

        public WeatherController(IServiceProvider services)
        {
            weatherService = services.GetService<IWeatherService>()!;
            context = services.GetService<MainPageContext>()!;
        }

    }
}
