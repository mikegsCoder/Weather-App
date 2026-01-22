using System.ComponentModel;
using WeatherApp.Core.Models.DTO;
using WeatherApp.Core.Models.ViewModels;

namespace WeatherApp.MAUI.DataContexts
{
    public class MainPageContext : INotifyPropertyChanged
    {
        private string? city = null;
        private bool hasCity = false;
        private bool notFound = false;
        private bool loading = false;
        private bool themeIsLight = true;
        private WeatherInfoModel? weatherData;
        private GeneralInfoViewModel? generalInfo = null;
        private List<InfoCardViewModel>? infoCards = null;
        private Color whiteColor = Colors.White;
        private Color blackColor = Colors.Black;

        public WeatherInfoModel WeatherData
        {
            get { return weatherData; }
            set { weatherData = value; }
        }

        public GeneralInfoViewModel GeneralInfo
        {
            get { return generalInfo; }
            set
            {
                generalInfo = value;
                NotifyPropertyChanged("GeneralInfo");
                NotifyPropertyChanged("Icon");
            }
        }

        public string Icon => "w" + generalInfo?.Icon.Substring(0, 3) + ".png";

        public List<InfoCardViewModel> InfoCards
        {
            get { return infoCards; }
            set { infoCards = value; NotifyPropertyChanged("InfoCards"); }
        }

        public bool ThemeIsLight
        {
            get { return themeIsLight; }
            set
            {
                themeIsLight = value;
                NotifyPropertyChanged("ThemeIsLight");
                NotifyPropertyChanged("TextColor");
                NotifyPropertyChanged("BackgroundColor");
            }
        }

        public string City
        {
            get { return city; }
            set { city = value; NotifyPropertyChanged("City"); }
        }

        public bool HasCity
        {
            get { return hasCity; }
            set { hasCity = value; NotifyPropertyChanged("HasCity"); }
        }

        public bool NotFound
        {
            get { return notFound; }
            set { notFound = value; NotifyPropertyChanged("NotFound"); }
        }

        public bool Loading
        {
            get { return loading; }
            set { loading = value; NotifyPropertyChanged("Loading"); }
        }

        public Color BackgroundColor => themeIsLight ? whiteColor : blackColor;

        public Color TextColor => themeIsLight ? blackColor : whiteColor;

        public void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
