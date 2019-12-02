using FHUBound.Models;
using FHUBound.Services;
using Xamarin.Forms;

namespace FHUBound
{
    public partial class App : Application
    {
        public static User CurrentUser { get; set; }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();

            CurrentUser = new User()
            {
                Username = "DShannon",
                CurrentPoints = 1000,
                Email = "Vcase@fhu.edu"
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
