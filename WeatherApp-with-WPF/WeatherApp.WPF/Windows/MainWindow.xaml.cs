using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Windows;
using WeatherApp.Core.Constants;
using WeatherApp.WPF.Controllers;
using WeatherApp.WPF.DataContexts;

namespace WeatherApp.WPF.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WeatherController weatherController;
        private MainWindowContext context;

        public ResourceDictionary ThemeDictionary
            => Resources.MergedDictionaries[0];
 
        public MainWindow(IServiceProvider services)
        {
            context = services.GetRequiredService<MainWindowContext>();
            weatherController = services.GetRequiredService<WeatherController>();

            InitializeComponent();

            DataContext = context;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        private void WPF_ClickHandler(object sender, RoutedEventArgs e)
            => OpenLink(UrlConstants.WpfUrl);

        private void DataProvider_ClickHandler(object sender, RoutedEventArgs e)
            => OpenLink(UrlConstants.DataProviderUrl);

        private void SourceCode_ClickHandler(object sender, RoutedEventArgs e)
            => OpenLink(UrlConstants.SourceCodeUrl);

        private void CityInput_ChangeHandler(object sender, RoutedEventArgs e)
            => context.HasCity = context.NotFound = false;

        private void SearchBtn_ClickHandler(object sender, RoutedEventArgs e)
        {
            string cityName = CityInput.Text.Trim();

            if (string.IsNullOrEmpty(cityName)) return;

            string capitalized = string.Concat(cityName[0].ToString().ToUpper(), cityName.AsSpan(1));
            CityInput.Text = capitalized;

            weatherController.GetWeatherInfo(cityName);
        }

        private void ExportJson_ClickHandler(object sender, RoutedEventArgs e)
            => weatherController.ExportWeatherData("json");

        private void ExportXml_ClickHandler(object sender, RoutedEventArgs e)
            => weatherController.ExportWeatherData("xml");

        private void ToggleTheme_ClickHandler(object sender, RoutedEventArgs e)
        {
            context.ThemeIsLight = !context.ThemeIsLight;

            SetTheme();
        }

        private void SetTheme()
        {
            string theme = context.ThemeIsLight ? "light" : "dark";

            var uri = new Uri(@"\Resources\Themes\" + theme + ".xaml", UriKind.Relative);

            ThemeDictionary.MergedDictionaries.Clear();
            ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary() { Source = uri });
        }

        private void OpenLink(string url)
        {
            var sInfo = new ProcessStartInfo(url) { UseShellExecute = true };

            Process.Start(sInfo);
        }
    }
}