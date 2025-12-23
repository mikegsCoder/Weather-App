namespace WeatherApp.MAUI
{
    public partial class App : Application
    {
        MainPage page;

        public App(IServiceProvider services)
        {
            InitializeComponent();

            page = services.GetService<MainPage>()!;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(page);

            const int newWidth = 1100;
            const int newHeight = 580;

            // Fixing window size:
            window.Width = window.MinimumWidth = window.MaximumWidth = newWidth;
            window.Height = window.MinimumHeight = window.MaximumHeight = newHeight;

            return window;
        }
    }
}