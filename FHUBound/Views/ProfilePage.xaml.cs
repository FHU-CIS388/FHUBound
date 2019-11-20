using FHUBound.Models;
using FHUBound.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            User = BindingContext = new ProfileViewModel();
        }
    }
}
