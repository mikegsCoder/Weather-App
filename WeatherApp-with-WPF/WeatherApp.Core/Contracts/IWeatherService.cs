﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Core.Models.DTO;

namespace WeatherApp.Core.Contracts
{
    public interface IWeatherService
    {
        Task<WeatherInfoModel> GetWeatherInfoAsync(string cityName);
    }
}
