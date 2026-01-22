namespace WeatherApp.Core.Models.ViewModels
{
    public class GeneralInfoViewModel
    {
        public string Icon { get; set; } = null!;
        public string NameAndCountry { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Temperature { get; set; } = null!;
        public string FeelsLike { get; set; } = null!;
    }
}
