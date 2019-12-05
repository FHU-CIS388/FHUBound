using FHUBound.ViewModels;
using System;
using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class HomePage : ContentPage
    {
        HomeViewModel viewModel;


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
        async void OpenCalendar(object sender, EventArgs e)
        {
            var calendar = new CalendarPage();
            await Navigation.PushModalAsync(calendar);
        }
    }
}