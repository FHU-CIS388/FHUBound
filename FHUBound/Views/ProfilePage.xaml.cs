using FHUBound.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class ProfilePage : ContentPage
    {
        ProfileViewModel viewModel;

        public ProfilePage()
        {
            

            InitializeComponent();

            BindingContext = viewModel = new ProfileViewModel();
        }

        private async void editButton_Clicked(object sender, EventArgs e)
        {
            App.CurrentUser.Username = "whoops";
            await Navigation.PushAsync(new EditProfilePage());
        }

       

        
    }
}
