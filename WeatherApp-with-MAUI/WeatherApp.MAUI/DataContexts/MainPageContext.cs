using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.MAUI.DataContexts
{
    public class MainPageContext : INotifyPropertyChanged
    {
        private string? city = null;
        private bool hasCity = false;
        private bool notFound = false;
        private bool loading = false;
        private bool themeIsLight = true;
        private Color whiteColor = Colors.White;
        private Color blackColor = Colors.Black;

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
