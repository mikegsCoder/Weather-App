﻿using System.ComponentModel;
using WeatherApp.Core.Models.DTO;
using WeatherApp.Core.Models.ViewModels;

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
        private GeneralInfoViewModel? generalInfo = null;
        private List<InfoCardViewModel>? infoCards = null;

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

        public string Icon
        {
            get { return @"/Resources/Images/WeatherIcons/" + generalInfo?.Icon.Substring(0, 3) + ".png"; }
        }

        public List<InfoCardViewModel> InfoCards
        {
            get { return infoCards; }
            set { infoCards = value; NotifyPropertyChanged("InfoCards"); }
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
