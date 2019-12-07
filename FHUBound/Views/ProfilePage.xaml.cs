using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using FHUBound.ViewModels;
using System.ComponentModel;


namespace FHUBound.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            
            BindingContext = new ProfileViewModel();
        }
        

        
        public async void EditButton(object sender, EventArgs args)
        {
            
            await Navigation.PushModalAsync(new NavigationPage(new ProfileEditPage()));
        }
    }
}
