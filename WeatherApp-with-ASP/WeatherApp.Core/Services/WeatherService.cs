using WeatherApp.Core.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using WeatherApp.Core.Models.DTO;
using WeatherApp.Core.Models.ViewModels;

namespace WeatherApp.Core.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _client;

        private readonly string _apiKey;
        private readonly string _baseUrl;

        public WeatherService(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _apiKey = configuration["ApiConstants:ApiKey"];
            _baseUrl = configuration["ApiConstants:BaseUrl"];
        }

        public async Task<Tuple<GeneralInfoViewModel, List<InfoCardViewModel>>> GetWeatherInfoAsync(string cityName)
        {
            var url = _baseUrl + "weather?q=" + cityName + "&appid=" + _apiKey;

            string json = await _client.GetStringAsync(url);
            WeatherInfoModel weatherInfo = JsonConvert.DeserializeObject<WeatherInfoModel>(json);

            var generalInfo = CreateGeneralInfo(weatherInfo);
            var infoCards = CreateInfoCards(weatherInfo);

            return new Tuple<GeneralInfoViewModel, List<InfoCardViewModel>>(generalInfo, infoCards);
        }

        private List<InfoCardViewModel> CreateInfoCards(WeatherInfoModel weatherInfo)
        {
            throw new NotImplementedException();
        }

        private GeneralInfoViewModel CreateGeneralInfo (WeatherInfoModel weatherInfo)
        {
            var generalInfo = new GeneralInfoViewModel
            {
                Icon = weatherInfo.Weather[0].Icon,
                Name = weatherInfo.Name,
                Country = weatherInfo.Sys.Country,
                Description = weatherInfo.Weather[0].Description,
                Temp = Math.Floor(weatherInfo.Main.Temp - 273.15).ToString("N0"),
                FeelsLike = Math.Floor(weatherInfo.Main.Feels_like - 273.15 - 1).ToString("N0")
            };

            return generalInfo;
        }
    }
}
