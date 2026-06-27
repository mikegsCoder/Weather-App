using Microsoft.AspNetCore.Components;
using WeatherApp.Core.Contracts;
using WeatherApp.Core.Models.ViewModels;

namespace WeatherApp.Web.Components
{
    public partial class Body
    {
        [Inject]
        private IWeatherService weatherService { get; set; } = null!;

        [Inject]
        private ILogger<Body> logger { get; set; } = null!;

        private bool isLoading = false;
        private bool notFound = false;
        private bool hasData = false;

        GeneralInfoViewModel GeneralInfo = new();
        List<InfoCardViewModel> InfoCards = new();

        public string? City { get; set; }

        public async Task Submit( string cityName)
        {
            City = cityName;

            logger.LogInformation("WeatherForm submitted with cityname = " + cityName);

            var result = await GetWeatherInfo(cityName);

            if (result == null)
            {
                notFound = true;
                hasData = false;
            }
            else
            {
                notFound = false;
                hasData = true;

                GeneralInfo = result.Item1;
                InfoCards = result.Item2;
            }
        }

        private async Task<Tuple<GeneralInfoViewModel, List<InfoCardViewModel>>> GetWeatherInfo(string cityName)
        {
            if (string.IsNullOrEmpty(cityName)) return null!;

            isLoading = true;
            hasData = false;
            notFound = false;

            try
            {
                var info = await weatherService.GetWeatherInfoAsync(cityName);

                logger.LogInformation(string.Concat(nameof(WeatherApp), " - ", nameof(GetWeatherInfo), ": ", "Country: ", info.Item1.Country, " City: ", info.Item1.Name, " Temperature: ", info.Item1.Temp));

                return info;
            }
            catch (Exception ex)
            {
                logger.LogError(string.Concat(nameof(WeatherApp), " - ", nameof(GetWeatherInfo), ": ", ex.Message), ex);

                return null!;
            }
            finally
            {
                isLoading = false;
            }
        }
    }
}
