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
            if (App.CurrentUser.Points <= 1000)
            {
                 DisplayAlert("Error", "not enough points", "OK");
            }
            else
            {
                App.CurrentUser.Points -= 1000;
                DisplayAlert("SUCCESS", "you bought this item", "OK");
            }
        }

        private void shirtButton_Clicked(object sender, EventArgs e)
        {
            if (App.CurrentUser.Points <= 850)
            {
                DisplayAlert("Error", "not enough points", "OK");
            }
            else
            {
                App.CurrentUser.Points -= 850;
                DisplayAlert("SUCCESS", "you bought this item", "OK");
            }
        }

        private void capButton_Clicked(object sender, EventArgs e)
        {
            if (App.CurrentUser.Points <= 500)
            {
                DisplayAlert("Error", "not enough points", "OK");
            }
            else
            {
                App.CurrentUser.Points -= 500;
                DisplayAlert("SUCCESS", "you bought this item", "OK");
            }
        }

        private void bookButton_Clicked(object sender, EventArgs e)
        {
            if (App.CurrentUser.Points <= 50)
            {
                DisplayAlert("Error", "not enough points", "OK");
            }
            else
            {
                App.CurrentUser.Points -= 50;
                DisplayAlert("SUCCESS", "you bought this item", "OK");
            }
        }

        private void giftButton_Clicked(object sender, EventArgs e)
        {
            if (App.CurrentUser.Points <= 5000)
            {
                DisplayAlert("Error", "not enough points", "OK");
            }
            else
            {
                App.CurrentUser.Points -= 5000;
                DisplayAlert("SUCCESS", "you bought this item", "OK");
            }
        }
    }
}
