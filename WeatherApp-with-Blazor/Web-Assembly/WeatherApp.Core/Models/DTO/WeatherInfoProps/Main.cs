using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core.Models.DTO.WeatherInfoProps
{
    public class Main
    {
        public double Temp { get; set; }
        public double Feels_like { get; set; }
        public double Temp_min { get; set; }
        public double Temp_max { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public double Sea_level { get; set; }
        public double Grnd_level { get; set; }
    }
}
