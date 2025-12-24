using System.Net.Http;
using System.Configuration;
using WeatherApp.MAUI;
using CommunityToolkit.Maui.Storage;
using WeatherApp.MAUI.DataContexts;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class WeatherAppServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<MainPageContext>();
            services.AddTransient<MainPage>();
            services.AddTransient<App>();

            return services;
        }
    }
}
