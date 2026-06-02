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
    }
}
