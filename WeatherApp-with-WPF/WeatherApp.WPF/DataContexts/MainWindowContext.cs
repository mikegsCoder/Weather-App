using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Core.Models.DTO;

namespace WeatherApp.WPF.DataContexts
{
    public class MainWindowContext : INotifyPropertyChanged
    {
        private string? city = null;
        private bool hasCity = false;
        private bool notFound = false;
        private bool loading = false;
        private bool themeIsLight = true;
        private WeatherInfoModel? weatherData;

        public WeatherInfoModel WeatherData
        {
            get { return weatherData; }
            set { weatherData = value; }
        }

        public bool ThemeIsLight
        {
            get { return themeIsLight; }
            set 
            { 
                themeIsLight = value; 
                NotifyPropertyChanged("ThemeIsLight"); 
                NotifyPropertyChanged("ThemeIsDark"); 
            }
        }

        public bool ThemeIsDark
        {
            get { return !themeIsLight; }
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
