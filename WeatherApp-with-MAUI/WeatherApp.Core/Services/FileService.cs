using Newtonsoft.Json;
using System.Text;
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

        private string SerializeData(WeatherInfoModel weatherData, string format)
        {
            string result;

            if (format == "json")
            {
                result = JsonConvert.SerializeObject(weatherData, Newtonsoft.Json.Formatting.Indented);
            }
            else
            {
                var sb = new StringBuilder();

                var serializer = new XmlSerializer(typeof(WeatherInfoModel), new XmlRootAttribute("WeatherData"));
                serializer.Serialize(new StringWriter(sb), weatherData, new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));
                result = sb.ToString();
            }

            return result;
        }
    }
}
