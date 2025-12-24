using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.MAUI.DataContexts;
using System.Globalization;

namespace WeatherApp.MAUI.Controllers
{
    public class WeatherController
    {
        private readonly MainPageContext context;

        public WeatherController(IServiceProvider services)
        {
            context = services.GetService<MainPageContext>()!;
        }
    }
}
