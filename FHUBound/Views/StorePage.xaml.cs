using FHUBound.ViewModels;
using System;
using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class StorePage : ContentPage
    {

        StoreViewModel viewModel;
        public StorePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new StoreViewModel();


        }
        async void OpenCalendar(object sender, EventArgs e)
        {
            var calendar = new CalendarPage();
            await Navigation.PushModalAsync(calendar);
        }

        //async void OnAlertYesNoClicked(object sender, EventArgs e)
        //{
        //    bool answer = await DisplayAlert("Confirm BoundBuck Transaction", "Is your information in order?" + Environment.NewLine + Environment.NewLine + "David Shannon" + Environment.NewLine + Environment.NewLine + "7707 Greene Farm Ct." + Environment.NewLine + "Ypsilanti, MI 48197", "Yes, send my prize!", "Nevermind");
        //    if (answer == true)
        //    {
        //        viewModel.RemoveBucks.Execute(5);
        //    }
        //}
    }
}
