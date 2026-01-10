using CommunityToolkit.Maui.Storage;
using System.Configuration;
using System.Net.Http;
using WeatherApp.Core.Contracts;
using WeatherApp.Core.Services;
using WeatherApp.MAUI;
using WeatherApp.MAUI.Controllers;
using WeatherApp.MAUI.DataContexts;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class WeatherAppServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IWeatherService), typeof(WeatherService));
            services.AddScoped<HttpClient>();
            services.AddScoped<WeatherController>();
            services.AddScoped<MainPageContext>();
            services.AddTransient<MainPage>();
            services.AddTransient<App>();

            return services;
        }
    }
}
