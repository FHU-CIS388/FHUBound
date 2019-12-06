using FHUBound.Models;
using FHUBound.ViewModels;
using System;
using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class HomePage : ContentPage
    {
        HomeViewModel viewModel;
        public User User { get; set; }

        public HomePage()
        {
            InitializeComponent();
            User = App.CurrentUser;

            BindingContext = viewModel = new HomeViewModel();
            OpenStreaksPage();

        }
        async void OpenStreaksPage()
        {
            User.Streak++;
            var streaks = new StreaksPage();
            await Navigation.PushModalAsync(streaks);
        }
        async void OpenCalendar(object sender, EventArgs e)
        {
            var calendar = new CalendarPage();
            await Navigation.PushModalAsync(calendar);
        }
    }
}