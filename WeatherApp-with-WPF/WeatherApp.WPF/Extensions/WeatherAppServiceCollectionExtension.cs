using WeatherApp.WPF;
using WeatherApp.WPF.DataContexts;
using WeatherApp.WPF.Windows;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class WeatherAppServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddSingleton<App>();
            services.AddSingleton<MainWindow>();
            services.AddScoped<MainWindowContext>();

            return services;
        }
    }
}
