using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FHUBound.Services;
using FHUBound.Views;
using FHUBound.Models;
using Xamarin.Essentials;

namespace FHUBound
{
    public partial class App : Application
    {
        public static User CurrentUser { get; set; } 
        public static UserDataStore userDataStore { get; set; }
        public App()
        {
            InitializeComponent();
            userDataStore = new UserDataStore();            
            if (IsLoggedIn())
            {
                MainPage = new AppShell();
            }
            else
            {
                MainPage = new LoginPage();
            }
            DependencyService.Register<MockDataStore>();            
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

        private bool IsLoggedIn()
        {
            string value = Preferences.Get("current_user_id", "default_value");
            try
            {
                CurrentUser = userDataStore.GetItemAsync(value).Result;
            }
            catch(Exception ex)
            {
                
            }
            return (CurrentUser != null);
        }
    }
}
