using System.Net.Http;
using System.Configuration;
using WeatherApp.MAUI;
using CommunityToolkit.Maui.Storage;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class WeatherAppServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<MainPage>();
            services.AddTransient<App>();

            return services;
        }
    }
}
