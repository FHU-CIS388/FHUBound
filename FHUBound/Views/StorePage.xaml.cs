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



        

        private void buyButton_Clicked(object sender, EventArgs e)
        {
            if (App.CurrentUser.Points >= 100)
            {
                DisplayAlert("Woohoo", "you bought this item", "back");
                App.CurrentUser.Points -= 100;
            }
            else
            {
                DisplayAlert("Oh no!", "you don't have enough points", "back");
            }
        }
    }
}
