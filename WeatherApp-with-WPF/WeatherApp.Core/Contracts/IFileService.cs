using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Core.Models.DTO;

namespace WeatherApp.Core.Contracts
{
    public interface IFileService
    {
        void ExportWeatherDataAsync(WeatherInfoModel weatherData, string path, string format);
    }
}
