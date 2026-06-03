using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WeatherApp.Core.Contracts;
using WeatherApp.Core.Models.ViewModels;
using WeatherApp.Core.Services;

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

        public async Task Submit(string cityName)
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
            throw new NotImplementedException();
        }
    }
}
