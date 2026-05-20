using Microsoft.AspNetCore.Components;

namespace WeatherApp.Web.Components
{
    public partial class NotFound
    {
        [Parameter]
        public string? CityName { get; set; }
    }
}
