using FHUBound.Models;
using FHUBound.ViewModels;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class StreaksPage : ContentPage
    {
        StreakViewModel viewModel;

        public StreaksPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new StreakViewModel();
        }
        async void CloseStreaksPage(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        
    }
}