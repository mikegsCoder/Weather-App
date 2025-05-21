using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WeatherApp.WPF.Windows;

namespace WeatherApp.WPF
{
    public class App : Application
    {
        readonly MainWindow mainWindow;

        public App(IServiceProvider services)
        {
            mainWindow = services.GetRequiredService<MainWindow>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}
