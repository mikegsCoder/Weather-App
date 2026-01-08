using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Storage;
using Microsoft.Maui.Controls;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using WeatherApp.Core.Constants;
using WeatherApp.MAUI.Controllers;
using WeatherApp.MAUI.DataContexts;

namespace WeatherApp.MAUI
{
    public partial class MainPage : ContentPage
    {
        private WeatherController weatherController;
        private MainPageContext context;

        public MainPage(IServiceProvider services)
        {
            context = services.GetService<MainPageContext>()!;
            weatherController = services.GetService<WeatherController>()!;

            InitializeComponent();

            BindingContext = context;
        }

        private void PointerEntered(object sender, EventArgs e)
        {
            var label = sender as Label;
            label!.TextDecorations = TextDecorations.Underline;
            label.FontAttributes = FontAttributes.Bold;
        }

        private void PointerExited(object sender, EventArgs e)
        {
            var label = sender as Label;
            label!.TextDecorations = TextDecorations.None;
            label.FontAttributes = FontAttributes.None;
        }

        private async void MAUI_ClickHandler(object sender, EventArgs e)
            => await Launcher.OpenAsync(UrlConstants.MauiUrl);

        private async void DataProvider_ClickHandler(object sender, EventArgs e)
            => await Launcher.OpenAsync(UrlConstants.DataProviderUrl);

        private async void SourceCode_ClickHandler(object sender, EventArgs e)
            => await Launcher.OpenAsync(UrlConstants.SourceCodeUrl);

        private void FileFormatPicker_SelectionHandler(object sender, EventArgs e)
        { }

        private void CityInput_ChangeHandler(object sender, EventArgs e)
            => context.HasCity = context.NotFound = false;

        private void SearchBtn_ClickHandler(object sender, EventArgs e)
        { }

        private void ToggleTheme_ClickHandler(object sender, ToggledEventArgs e)
        {
            context.ThemeIsLight = !context.ThemeIsLight;

            Application.Current!.UserAppTheme = context.ThemeIsLight ? AppTheme.Light : AppTheme.Dark;
        }
    }
}
