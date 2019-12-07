using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FHUBound.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FHUBound.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileEditPage : ContentPage
    {
        public ProfileEditPage()
        {
            InitializeComponent();
            BindingContext = new ProfileViewModel();
        }

        
        public async void OnButtonClicked(object sender, EventArgs args)
        {
            App.CurrentUser.Username = Username.Text;
            App.CurrentUser.Firstname = FirstName.Text;
            App.CurrentUser.Lastname = LastName.Text;
            App.CurrentUser.Email = Email.Text;
            App.CurrentUser.Address = Address.Text;


            if (App.CurrentUser.Username == null || App.CurrentUser.Firstname == null || App.CurrentUser.Lastname == null || App.CurrentUser.Email == null || App.CurrentUser.Address == null || App.CurrentUser.Password == null)
            {
                await DisplayAlert("Empty Fields", "Please finish filling out your information", "OK");
            }
            else
            {
                
                await Navigation.PopModalAsync();
            }
        }
    }
    
}