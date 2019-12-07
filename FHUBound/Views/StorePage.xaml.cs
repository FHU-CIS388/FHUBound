using FHUBound.ViewModels;
using System;
using FHUBound.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FHUBound.Views


{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class StorePage : ContentPage 
    {


        StoreViewModel viewModel;


        public StorePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new StoreViewModel();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            if(viewModel.Items.Count == 0)
            {
                viewModel.LoadItemsCommand.Execute(null);
            }
        }



        private void  jacket_click(object sender, EventArgs e)
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

        private void shirt_click(object sender, EventArgs e)
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

        private void cap_click(object sender, EventArgs e)
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

        private void book_click(object sender, EventArgs e)
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

        private void gift_click(object sender, EventArgs e)
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

        private void buyButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Woohoo", "you bought this item", "back");
            App.CurrentUser.Points -= 100;
            
        }
    }
}
