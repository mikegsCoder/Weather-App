using WeatherApp.Core.Models.ViewModels;

namespace WeatherApp.Core.Contracts
{
    public interface IWeatherService
    {
        Task<Tuple<GeneralInfoViewModel, List<InfoCardViewModel>>> GetWeatherInfoAsync(string cityName);
    }
}
