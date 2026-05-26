using WeatherApp.Core.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using WeatherApp.Core.Models.DTO;
using WeatherApp.Core.Models.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace WeatherApp.Core.Services
{
    public class WeatherService : IWeatherService
    {
        public Task<Tuple<GeneralInfoViewModel, List<InfoCardViewModel>>> GetWeatherInfoAsync(string cityName)
        {
            throw new NotImplementedException();
        }
    }
}
