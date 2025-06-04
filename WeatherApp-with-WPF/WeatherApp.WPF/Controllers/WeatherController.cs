using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Core.Contracts;
using WeatherApp.WPF.DataContexts;

namespace WeatherApp.WPF.Controllers
{
    public class WeatherController
    {
        private readonly MainWindowContext context;
        private readonly IWeatherService weatherService;
        private readonly IFileService fileService;

        public WeatherController(IServiceProvider services)
        {
            weatherService = services.GetRequiredService<IWeatherService>();
            fileService = services.GetRequiredService<IFileService>();
            context = services.GetRequiredService<MainWindowContext>();
        }

        public async void GetWeatherInfo(string cityName)
        {
            throw new NotImplementedException();
        }

        public void ExportWeatherData(string format)
        {
            throw new NotImplementedException();
        }
    }
}
