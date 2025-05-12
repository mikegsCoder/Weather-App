using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Core.Models.ViewModels;

namespace WeatherApp.Core.Contracts
{
    public interface IWeatherService
    {
        Task<Tuple<GeneralInfoViewModel, List<InfoCardViewModel>>> GetWeatherInfoAsync(string cityName);
    }
}
