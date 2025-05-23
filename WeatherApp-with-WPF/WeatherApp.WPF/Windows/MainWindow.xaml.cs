using System.Windows;

namespace WeatherApp.WPF.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ResourceDictionary ThemeDictionary
            => Resources.MergedDictionaries[0];

        public MainWindow(IServiceProvider services)
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        private void WPF_ClickHandler(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ToggleTheme_ClickHandler(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}