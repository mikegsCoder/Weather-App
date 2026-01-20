using CommunityToolkit.Maui.Storage;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Core.Contracts;
using WeatherApp.Core.Models.DTO;
using WeatherApp.Core.Models.ViewModels;
using WeatherApp.MAUI.DataContexts;

namespace WeatherApp.MAUI.Controllers
{
    public class WeatherController
    {
        private readonly MainPageContext context;
        private readonly IWeatherService weatherService;
        private readonly IFileService fileService;
        private readonly IFolderPicker folderPicker;

        public WeatherController(IServiceProvider services)
        {
            weatherService = services.GetService<IWeatherService>()!;
            fileService = services.GetService<IFileService>()!;
            context = services.GetService<MainPageContext>()!;
            folderPicker = services.GetService<IFolderPicker>()!;
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
            var generalInfo = new GeneralInfoViewModel
            {
                Icon = weatherInfo.Weather[0].Icon,
                NameAndCountry = weatherInfo.Name + ", " + weatherInfo.Sys.Country,
                Description = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(weatherInfo.Weather[0].Description.ToLower()),
                Temperature = Math.Floor(weatherInfo.Main.Temp - 273.15).ToString("N0") + "°C",
                FeelsLike = "Feels Like: " + Math.Floor(weatherInfo.Main.Feels_like - 273.15 - 1).ToString("N0") + "°C"
            };

            return generalInfo;
        }

        public async Task<Tuple<bool, string>> ExportWeatherData(string fileFormat)
        {
            throw new NotImplementedException();
        }
    }
}
