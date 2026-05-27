using WeatherApp.Core.Contracts;
using WeatherApp.Core.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class WeatherAppServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IWeatherService), typeof(WeatherService));
            services.AddScoped<HttpClient>();

            return services;
        }
    }
}
