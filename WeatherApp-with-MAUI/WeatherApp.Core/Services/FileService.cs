using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using WeatherApp.Core.Contracts;
using WeatherApp.Core.Models.DTO;

namespace WeatherApp.Core.Services
{
    public class FileService : IFileService
    {
        public async void ExportWeatherDataAsync(WeatherInfoModel weatherData, string path, string format)
        {
            var result = SerializeData(weatherData, format);

            await File.WriteAllTextAsync(path + "/WeatherData." + format, result);
        }

        private string? SerializeData(WeatherInfoModel weatherData, string format)
        {
            throw new NotImplementedException();
        }
    }
}
