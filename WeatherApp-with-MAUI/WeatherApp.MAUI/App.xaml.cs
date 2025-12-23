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
            return new Window(new MainPage());
        }
    }
}