using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WeatherApp.WPF.DataContexts;

namespace WeatherApp.WPF.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowContext context;

        public ResourceDictionary ThemeDictionary
            => Resources.MergedDictionaries[0];

        public MainWindow(IServiceProvider services)
        {
            context = services.GetRequiredService<MainWindowContext>();

            InitializeComponent();

            DataContext = context;
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
            context.ThemeIsLight = !context.ThemeIsLight;

            SetTheme();
        }

        private void SetTheme()
        {
            string theme = context.ThemeIsLight ? "light" : "dark";

            var uri = new Uri(@"\Resources\Themes\" + theme + ".xaml", UriKind.Relative);

            ThemeDictionary.MergedDictionaries.Clear();
            ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary() { Source = uri });
        }
    }
}