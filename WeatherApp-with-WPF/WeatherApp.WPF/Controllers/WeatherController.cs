using Microsoft.Extensions.DependencyInjection;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Globalization;
using WeatherApp.Core.Constants;
using WeatherApp.Core.Contracts;
using WeatherApp.Core.Models.DTO;
using WeatherApp.Core.Models.ViewModels;
using WeatherApp.WPF.DataContexts;
using static WeatherApp.WPF.Windows.MessageBoxes.MessageBoxes;


namespace WeatherApp.WPF.Controllers
{
    public class WeatherController
    {
        private readonly MainWindowContext context;
        private readonly IWeatherService weatherService;
        private readonly IFileService fileService;

        public WeatherController(IServiceProvider services)
        {
            weatherService = services.GetRequiredService<IWeatherService>();
            fileService = services.GetRequiredService<IFileService>();
            context = services.GetRequiredService<MainWindowContext>();
        }

        public async void GetWeatherInfo(string cityName)
        {
            context.HasCity = false;
            context.NotFound = false;
            context.Loading = true;
            context.City = cityName;

            try
            {
                var weatherInfo = await weatherService.GetWeatherInfoAsync(cityName);

                context.WeatherData = weatherInfo;
                context.GeneralInfo = CreateGeneralInfo(weatherInfo); ;
                context.InfoCards = CreateInfoCards(weatherInfo);
                context.HasCity = true;
            }
            catch (Exception ex)
            {
                context.GeneralInfo = null;
                context.InfoCards = null;
                context.NotFound = true;
            }
            finally
            {
                context.Loading = false;
            }
        }

        public void ExportWeatherData(string format)
        {
            string path;

            try
            {
                var dialog = new CommonOpenFileDialog();
                dialog.Title = "Select location to save weather data:";
                dialog.IsFolderPicker = true;
                CommonFileDialogResult result = dialog.ShowDialog();

                path = dialog.FileName;
            }
            catch (Exception ex)
            {
                ShowError(MessageConstants.FolderSelectionError);
                return;
            }

            try
            {
                fileService.ExportWeatherDataAsync(context.WeatherData, path, format);

                ShowSuccess(string.Format(MessageConstants.DataExportSuccess, path, format));
            }
            catch (Exception ex)
            {
                ShowError(MessageConstants.DataExportError);
            }
        }

        private List<InfoCardViewModel> CreateInfoCards(WeatherInfoModel weatherInfo)
        {
            var pressure = new InfoCardViewModel
            {
                Icon = @"/Resources/Images/InfoCards/meter.png",
                Content = "Pressure: " + weatherInfo.Main.Pressure + "hPa"
            };

            var humidity = new InfoCardViewModel
            {
                Icon = @"/Resources/Images/InfoCards/droplet.png",
                Content = "Humidity: " + weatherInfo.Main.Humidity + "%"
            };

            var visibility = new InfoCardViewModel
            {
                Icon = @"/Resources/Images/InfoCards/eye.png",
                Content = "Visibility: " + weatherInfo.Visibility / 1000 + "km"
            };

            var windSpeed = new InfoCardViewModel
            {
                Icon = @"/Resources/Images/InfoCards/wind.png",
                Content = "Wind Speed: " + weatherInfo.Wind.Speed + "km/h"
            };

            var windDirection = new InfoCardViewModel
            {
                Icon = @"/Resources/Images/InfoCards/compass.png",
                Content = "Wind Direction: " + weatherInfo.Wind.Deg + "deg"
            };

            var cloudiness = new InfoCardViewModel
            {
                Icon = @"/Resources/Images/InfoCards/cloud.png",
                Content = "Cloudiness: " + weatherInfo.Clouds.All + "%"
            };

            return new List<InfoCardViewModel>
            {
                pressure,
                humidity,
                visibility,
                windSpeed,
                windDirection,
                cloudiness
            };
        }

        private GeneralInfoViewModel CreateGeneralInfo(WeatherInfoModel weatherInfo)
        {
            var generalInfo = new GeneralInfoViewModel
            {
                Icon = weatherInfo.Weather[0].Icon,
                NameAndCountry = weatherInfo.Name + ", " + weatherInfo.Sys.Country,
                Description = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(weatherInfo.Weather[0].Description.ToLower()),
                Temperature = Math.Floor(weatherInfo.Main.Temp - 273.15).ToString("N0") + "°C",
                FeelsLike = "Feels Like: " + Math.Floor(weatherInfo.Main.Feels_like - 273.15 - 1).ToString("N0") + "°C"
            };

            return generalInfo;
        }
    }
}
