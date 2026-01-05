using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Core.Constants;
using WeatherApp.Core.Contracts;
using WeatherApp.Core.Models.DTO;

namespace WeatherApp.Core.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient client;

        public WeatherService(IServiceProvider services)
        {
            client = services.GetRequiredService<HttpClient>();
        }

        public async Task<WeatherInfoModel> GetWeatherInfoAsync(string cityName)
        {
            throw new NotImplementedException();
        }
    }
}
