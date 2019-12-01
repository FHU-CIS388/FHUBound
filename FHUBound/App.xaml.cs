using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FHUBound.Services;
using FHUBound.Views;
using FHUBound.Models;

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

            CurrentUser = new User() { Username = "jjcannon52", Points = 200, TotalPoints = 2000, FirstName = "jack", LastName = "cannon", Level = 100};
        }

        protected override void OnStart()
        {
            if(App.CurrentUser.TotalPoints >= 1000)
            {
                App.CurrentUser.Level = 1;
            } else if (App.CurrentUser.TotalPoints >= 2000)
            {
                App.CurrentUser.Level = 2;
            }
            else if (App.CurrentUser.TotalPoints >= 3000)
            {
                App.CurrentUser.Level = 3;
            }
            else if (App.CurrentUser.TotalPoints >= 4000)
            {
                App.CurrentUser.Level = 4;
            }
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
