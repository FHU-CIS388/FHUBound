using System;
using System.Collections.Generic;
using FHUBound.ViewModels;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace FHUBound.Views
{
    
    public partial class ProfilePage : ContentPage
    {
        ProfileViewModel viewModel;
        public ProfilePage()
        {
            InitializeComponent();
            viewModel = new ProfileViewModel();
            BindingContext = viewModel;
        }

        private void btnLogOut_Clicked(object sender, EventArgs e)
        {
            Preferences.Remove("current_user_id");
        }
    }
}
