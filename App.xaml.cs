using Microsoft.Extensions.DependencyInjection;

namespace EconOwl
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = new Window(new AppShell());

            window.MinimumWidth = 400;
            window.MinimumHeight = 600;

            return window;
        }

        // Those functions are application properties that can be overriden.
        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }
    }
}