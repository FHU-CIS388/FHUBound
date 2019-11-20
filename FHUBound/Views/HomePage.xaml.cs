using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FHUBound.Models;
using FHUBound.ViewModels;
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

        }

    }
}
