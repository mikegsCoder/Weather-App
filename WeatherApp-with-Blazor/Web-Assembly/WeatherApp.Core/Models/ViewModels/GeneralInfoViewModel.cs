using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core.Models.ViewModels
{
    public class GeneralInfoViewModel
    {
        public string Icon { get; set; } = "";
        public string Name { get; set; } = "";
        public string Country { get; set; } = "";
        public string Description { get; set; } = "";
        public string Temp { get; set; } = "";
        public string FeelsLike { get; set; } = "";
    }
}
