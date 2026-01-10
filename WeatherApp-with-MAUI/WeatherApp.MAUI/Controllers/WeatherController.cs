using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.MAUI.DataContexts;
using System.Globalization;
using WeatherApp.Core.Contracts;
using WeatherApp.Core.Models.ViewModels;
using WeatherApp.Core.Models.DTO;

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

        public async void GetWeatherInfo(string cityName)
        {
            context.HasCity = false;
            context.NotFound = false;
            context.Loading = true;
            context.City = cityName;

            try
            {
                var weatherInfo = await weatherService.GetWeatherInfoAsync(cityName);

                context.WeatherData = weatherInfo;
                context.GeneralInfo = CreateGeneralInfo(weatherInfo); ;
                context.InfoCards = CreateInfoCards(weatherInfo);
                context.HasCity = true;
            }
            catch (Exception ex)
            {
                context.GeneralInfo = null;
                context.InfoCards = null;
                context.NotFound = true;
            }
            finally
            {
                context.Loading = false;
            }
        }

        private List<InfoCardViewModel> CreateInfoCards(WeatherInfoModel weatherInfo)
        {
            var pressure = new InfoCardViewModel
            {
                Icon = "meter.png",
                Content = "Pressure: " + weatherInfo.Main.Pressure + "hPa"
            };

            var humidity = new InfoCardViewModel
            {
                Icon = "droplet.png",
                Content = "Humidity: " + weatherInfo.Main.Humidity + "%"
            };

            var visibility = new InfoCardViewModel
            {
                Icon = "eye.png",
                Content = "Visibility: " + weatherInfo.Visibility / 1000 + "km"
            };

            var windSpeed = new InfoCardViewModel
            {
                Icon = "wind.png",
                Content = "Wind Speed: " + weatherInfo.Wind.Speed + "km/h"
            };

            var windDirection = new InfoCardViewModel
            {
                Icon = "compass.png",
                Content = "Wind Direction: " + weatherInfo.Wind.Deg + "deg"
            };

            var cloudiness = new InfoCardViewModel
            {
                Icon = "cloud.png",
                Content = "Cloudiness: " + weatherInfo.Clouds.All + "%"
            };

            return new List<InfoCardViewModel>
            {
                pressure,
                humidity,
                visibility,
                windSpeed,
                windDirection,
                cloudiness
            };
        }

        private GeneralInfoViewModel CreateGeneralInfo(WeatherInfoModel weatherInfo)
        {
            throw new NotImplementedException();
        }
    }
}
