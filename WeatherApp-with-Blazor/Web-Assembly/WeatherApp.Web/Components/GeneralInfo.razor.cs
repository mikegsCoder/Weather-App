using Microsoft.AspNetCore.Components;
using WeatherApp.Core.Models.ViewModels;

namespace WeatherApp.Web.Components
{
    public partial class GeneralInfo
    {
        [Parameter]
        public GeneralInfoViewModel? GeneralInfoModel { get; set; }
    }
}
