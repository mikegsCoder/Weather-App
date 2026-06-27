namespace WeatherApp.Core.Models.DTO.WeatherInfoProps
{
    public class Weather
    {
        public double Id { get; set; }
        public string Main { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Icon { get; set; } = null!;
    }
}
