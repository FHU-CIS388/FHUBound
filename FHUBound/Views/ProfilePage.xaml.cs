using System;
using System.Collections.Generic;
using FHUBound.ViewModels;
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
    }
}
