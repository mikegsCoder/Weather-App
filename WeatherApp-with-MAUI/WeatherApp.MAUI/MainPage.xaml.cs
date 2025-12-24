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
    }
}
