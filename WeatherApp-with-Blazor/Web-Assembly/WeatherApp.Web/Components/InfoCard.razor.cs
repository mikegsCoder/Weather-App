using Microsoft.AspNetCore.Components;
using WeatherApp.Core.Models.ViewModels;

namespace WeatherApp.Web.Components
{
    public partial class InfoCard
    {
        [Parameter]
        public InfoCardViewModel? InfoCardModel { get; set; }
    }
}
