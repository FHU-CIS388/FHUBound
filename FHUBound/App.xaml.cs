using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
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
            App.CurrentUser = new User();

            if (Preferences.Get("UserName", "") == "")
            {
                App.CurrentUser.Username = "New User";
            }


        }

        protected override void OnStart()
        {
            LoadUser();
            App.CurrentUser.CalculateLevel();

        }

        public void SaveUser()
        {
            Preferences.Set("UserName", App.CurrentUser.Username);
            Preferences.Set("TotalPoints", App.CurrentUser.TotalPoints);
            Preferences.Set("Points", App.CurrentUser.Points);
            Preferences.Set("FirstName", App.CurrentUser.FirstName);
            Preferences.Set("LastName", App.CurrentUser.LastName);

        }

        public void LoadUser()
        {
            App.CurrentUser.Username = Preferences.Get("UserName", "");
            if(App.CurrentUser.Username == "")
            {
                App.CurrentUser = new User { Username="New User" };
                return;
            }

            App.CurrentUser.TotalPoints = Preferences.Get("TotalPoints", 0);
            App.CurrentUser.Points = Preferences.Get("Points", 0);
            App.CurrentUser.FirstName = Preferences.Get("FirstName", "");
            App.CurrentUser.LastName = Preferences.Get("LastName", "");


        }



        protected override void OnSleep()
        {
            SaveUser();
        
        }

        protected override void OnResume()
        {
            LoadUser();
        }

       
    }
}
