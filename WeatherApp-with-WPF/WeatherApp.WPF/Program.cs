using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace WeatherApp.WPF
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            var host = Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddApplicationServices();
            })
            .Build();

            var app = host.Services.GetService<App>();
            app!.ShutdownMode = System.Windows.ShutdownMode.OnExplicitShutdown;

            app?.Run();
        }
    }
}
