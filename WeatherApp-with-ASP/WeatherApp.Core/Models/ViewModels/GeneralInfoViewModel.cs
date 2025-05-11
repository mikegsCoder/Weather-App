namespace WeatherApp.Core.Models.ViewModels
{
    public class GeneralInfoViewModel
    {
        public string Icon { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Temp { get; set; } = null!;
        public string FeelsLike { get; set; } = null!;
    }
}
