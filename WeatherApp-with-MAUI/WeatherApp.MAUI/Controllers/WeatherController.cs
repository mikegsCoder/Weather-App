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
            throw new NotImplementedException();
        }

        private GeneralInfoViewModel CreateGeneralInfo(WeatherInfoModel weatherInfo)
        {
            throw new NotImplementedException();
        }
    }
}
