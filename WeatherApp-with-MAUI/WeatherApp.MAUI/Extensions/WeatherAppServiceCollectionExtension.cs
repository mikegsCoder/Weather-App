using System.Net.Http;
using System.Configuration;
using WeatherApp.MAUI;
using CommunityToolkit.Maui.Storage;
using WeatherApp.MAUI.DataContexts;
using WeatherApp.MAUI.Controllers;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class WeatherAppServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<HttpClient>();
            services.AddScoped<WeatherController>();
            services.AddScoped<MainPageContext>();
            services.AddTransient<MainPage>();
            services.AddTransient<App>();

            return services;
        }
    }
}
