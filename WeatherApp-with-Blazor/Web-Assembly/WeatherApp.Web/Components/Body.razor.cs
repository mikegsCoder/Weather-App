using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WeatherApp.Core.Models.ViewModels;

namespace WeatherApp.Web.Components
{
    public partial class Body
    {
        private bool isLoading = false;
        private bool notFound = false;
        private bool hasData = false;

        GeneralInfoViewModel GeneralInfo = new();
        List<InfoCardViewModel> InfoCards = new();

        public string? City { get; set; }

        public async Task Submit( string cityName)
        {
        }
    }
}
