using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class StorePage : ContentPage
    {
        async void OnDisplayActionSheetButtonClicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Confirm?",  "No", "Yes");
            Console.WriteLine("Action: " + action);
        }
        public StorePage()
        {
            InitializeComponent();
        }
    }
}
