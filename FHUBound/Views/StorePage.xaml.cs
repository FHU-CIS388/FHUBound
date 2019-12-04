using System;
using System.Collections.Generic;
using FHUBound.ViewModels;
using FHUBound.Models;
using Xamarin.Forms;

namespace FHUBound.Views
{
    
    public partial class StorePage : ContentPage
    {
        StoreViewModel viewModel;
        async void OnDisplayActionSheetButtonClicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Confirm?",  "No", "Yes");
            Console.WriteLine("Action: " + action);
        }

         
        public StorePage()
        {
         
            InitializeComponent();

           viewModel = new StoreViewModel();
           BindingContext = viewModel;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (viewModel.StoreItems.Count == 0) viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
