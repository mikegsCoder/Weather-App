using WeatherApp.Core.Contracts;
using Newtonsoft.Json;
using WeatherApp.Core.Models.DTO;
using WeatherApp.Core.Constants;
using Microsoft.Extensions.DependencyInjection;


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
            var url = ApiConstants.BaseUrl + "weather?q=" + cityName + "&appid=" + ApiConstants.ApiKey;

            string json = await client.GetStringAsync(url);
            WeatherInfoModel weatherInfo = JsonConvert.DeserializeObject<WeatherInfoModel>(json)!;

            return weatherInfo;
        }
    }
}
