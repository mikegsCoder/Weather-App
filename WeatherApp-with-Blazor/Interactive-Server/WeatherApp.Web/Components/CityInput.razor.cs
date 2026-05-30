using Microsoft.AspNetCore.Components;

namespace WeatherApp.Web.Components
{
    public partial class CityInput
    {
        [Parameter]
        public EventCallback<string> OnSubmitCallback { get; set; }

        private string city = string.Empty;

        public string City
        {
            get => city;
            set
            {
                if (value == city) return;

                city = value;
            }
        }

        private async Task SendData()
        {
            await OnSubmitCallback.InvokeAsync(City);
        }
    }
}
