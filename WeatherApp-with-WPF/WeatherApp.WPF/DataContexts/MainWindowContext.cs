﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.WPF.DataContexts
{
    public class MainWindowContext : INotifyPropertyChanged
    {
        private bool themeIsLight = true;

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
