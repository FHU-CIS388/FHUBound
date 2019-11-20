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

            CurrentUser = new User() { Username = "Person", CurrentPoints = 1000, Email = "kcasey@fhu.edu" };
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
