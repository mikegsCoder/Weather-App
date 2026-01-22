using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using WeatherApp.Core.Constants;
using WeatherApp.Core.Contracts;
using WeatherApp.Core.Models.DTO;

namespace WeatherApp.Core.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient client;

        public WeatherService(IServiceProvider services)
        {
            client = services.GetRequiredService<HttpClient>();
        }

        public async Task<WeatherInfoModel> GetWeatherInfoAsync(string cityName)
        {
            string url = ApiConstants.BaseUrl + "weather?q=" + cityName + "&appid=" + ApiConstants.ApiKey;

            string json = await client.GetStringAsync(url);
            WeatherInfoModel weatherInfo = JsonConvert.DeserializeObject<WeatherInfoModel>(json)!;

            return weatherInfo;
        }
    }
}
