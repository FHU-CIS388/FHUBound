using System;
using System.Collections.Generic;

using Xamarin.Forms;
using FHUBound.ViewModels;

namespace FHUBound.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();

            BindingContext = new ProfileViewModel();
        }
    }
}
