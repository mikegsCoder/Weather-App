using WeatherApp.Core.Contracts;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
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
            var pressure = new InfoCardViewModel
            {
                Icon = "fa-solid fa-gauge-high",
                Value = weatherInfo.Main.Pressure,
                Units = "hPa",
                Text = "Pressure"
            };

            var humidity = new InfoCardViewModel
            {
                Icon = "fa-solid fa-droplet",
                Value = weatherInfo.Main.Humidity,
                Units = "%",
                Text = "Humidity"
            };

            var visibility = new InfoCardViewModel
            {
                Icon = "fa-solid fa-eye",
                Value = weatherInfo.Visibility / 1000,
                Units = "km",
                Text = "Visibility"
            };

            var windSpeed = new InfoCardViewModel
            {
                Icon = "fa-solid fa-wind",
                Value = weatherInfo.Wind.Speed,
                Units = "km/h",
                Text = "Wind Speed"
            };

            var windDirection = new InfoCardViewModel
            {
                Icon = "fa-solid fa-compass",
                Value = weatherInfo.Wind.Deg,
                Units = "deg",
                Text = "Wind Direction"
            };

            var cloudiness = new InfoCardViewModel
            {
                Icon = "fa-solid fa-cloud",
                Value = weatherInfo.Clouds.All,
                Units = "%",
                Text = "Cloudiness"
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
