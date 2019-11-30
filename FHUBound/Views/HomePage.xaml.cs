using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using FHUBound.Models;
using FHUBound.ViewModels;
using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class HomePage : ContentPage
    {
        HomeViewModel viewModel;
        //public new Xamarin.Forms.INavigation Navigation { get; }

        public HomePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new HomeViewModel();
            OpenStreaksPage();

        }
        async void OpenStreaksPage()
        {
            var streaks = new StreaksPage();
            await Navigation.PushModalAsync(streaks);
        }

        //TODO: test for button, but button wouldnt click
        async void OpenCalendar(object sender, EventArgs e)
        {
            Console.WriteLine("CODE BEHIND");
            bool answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            Debug.WriteLine("Answer: " + answer);
        }

    }
}
