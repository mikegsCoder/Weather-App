using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Core.Contracts;
using WeatherApp.Core.Models.DTO;
using WeatherApp.Core.Models.ViewModels;
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
        
        public void ExportWeatherData(string format)
        {
            throw new NotImplementedException();
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
