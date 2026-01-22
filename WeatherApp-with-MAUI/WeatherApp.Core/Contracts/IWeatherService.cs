using WeatherApp.Core.Models.DTO;

namespace WeatherApp.Core.Contracts
{
    public interface IWeatherService
    {
        Task<WeatherInfoModel> GetWeatherInfoAsync(string cityName);
    }
}
