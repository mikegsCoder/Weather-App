using WeatherApp.Core.Contracts;
using WeatherApp.Core.Services;

namespace WeatherApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddHttpClient();
            builder.Services.AddSingleton(typeof(IWeatherService), typeof(WeatherService));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Weather/Error");
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Weather}/{action=Index}");

            app.Run();
        }
    }
}
