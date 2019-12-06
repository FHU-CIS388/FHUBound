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
<<<<<<< HEAD

        public Command ButtonClicked = new Command((object item) =>
        {
            StoreItem model = item as StoreItem;
            
            App.Current.MainPage.DisplayAlert("",model.Description,"");
            
            
        });


=======
>>>>>>> 82cbf6880505a22d0c306d0b70bfb9f04c69a012
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (viewModel.StoreItems.Count == 0) viewModel.LoadItemsCommand.Execute(null);
        }

        private async System.Threading.Tasks.Task ImageButton_ClickedAsync(object sender, EventArgs e)
        {
            
        }
    }
}
