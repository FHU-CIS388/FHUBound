using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class StorePage : ContentPage
    {
        public StorePage()
        {
            InitializeComponent();
        }

       

        private void  testButton_Clicked(object sender, EventArgs e)
        {
            if (App.CurrentUser.Points <= 100)
            {
                 DisplayAlert("Error", "not enough points", "OK");
            }
            else
            {
                DisplayAlert("SUCCESS", "you bought this item", "OK");
            }
        }

       
    }
}
