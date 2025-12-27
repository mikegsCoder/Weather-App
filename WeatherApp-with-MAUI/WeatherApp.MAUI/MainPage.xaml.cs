using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Storage;
using Microsoft.Maui.Controls;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
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
        { }

        private void PointerExited(object sender, EventArgs e)
        { }

        private void MAUI_ClickHandler(object sender, EventArgs e)
        { }

        private void DataProvider_ClickHandler(object sender, EventArgs e)
        { }

        private void ToggleTheme_ClickHandler(object sender, ToggledEventArgs e)
        { }
    }
}
