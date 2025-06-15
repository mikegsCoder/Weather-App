using WeatherApp.Core.Models.DTO;

namespace WeatherApp.Core.Contracts
{
    public interface IFileService
    {
        void ExportWeatherDataAsync(WeatherInfoModel weatherData, string path, string format);
    }
}
