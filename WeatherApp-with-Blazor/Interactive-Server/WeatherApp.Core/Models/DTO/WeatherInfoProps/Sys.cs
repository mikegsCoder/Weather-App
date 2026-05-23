using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core.Models.DTO.WeatherInfoProps
{
    public class Sys
    {
        public double Type { get; set; }
        public double Id { get; set; }
        public string Country { get; set; } = null!;
        public double Sunrise { get; set; }
        public double Sunset { get; set; }
    }
}
