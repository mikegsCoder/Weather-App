using WeatherApp.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using WeatherApp.Core.Models.DTO;
using System.Globalization;
using WeatherApp.Core.Constants;

namespace WeatherApp.Core.Services
{
    public class WeatherService : IWeatherService
    {
        public async Task<WeatherInfoModel> GetWeatherInfoAsync(string cityName)
        {
            throw new NotImplementedException();
        }
    }
}
