using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Core.Models.DTO.WeatherInfoProps;

namespace WeatherApp.Core.Models.DTO
{
    public class WeatherInfoModel
    {
        public Coord Coord { get; set; } = null!;
        public Weather[] Weather { get; set; } = null!;
        public string Base { get; set; } = null!;
        public Main Main { get; set; } = null!;
        public double Visibility { get; set; }
        public Wind Wind { get; set; } = null!;
        public Clouds Clouds { get; set; } = null!;
        public double Dt { get; set; }
        public Sys Sys { get; set; } = null!;
        public double Timezone { get; set; }
        public double Id { get; set; }
        public string Name { get; set; } = null!;
        public double Cod { get; set; }
    }
}
