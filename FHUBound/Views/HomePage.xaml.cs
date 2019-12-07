using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FHUBound.Models;
using Xamarin.Forms;
using FHUBound.ViewModels;

namespace FHUBound.Views
{
    public partial class HomePage : ContentPage
    {


        
        public HomePage()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();

            


        }

        

        
        
    }
}
