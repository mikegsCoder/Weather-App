namespace WeatherApp.Core.Models.ViewModels
{
    public class InfoCardViewModel
    {
        public string Icon { get; set; } = null!;
        public double Value { get; set; }
        public string Units { get; set; } = null!;
        public string Text { get; set; } = null!;
    }
}
