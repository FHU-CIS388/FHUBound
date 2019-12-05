﻿using System;
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
        public static UserDataStore userDataStore { get; set; }
        public App()
        {
            InitializeComponent();
            userDataStore = new UserDataStore();
            CurrentUser = userDataStore.GetItemAsync("Nemo").Result;

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
