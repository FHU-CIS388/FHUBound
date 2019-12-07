using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FHUBound.Models;

namespace FHUBound.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }
        public async void OnButtonClicked(object sender, EventArgs args)
        {
            App.CurrentUser.Username = Username.Text;
            App.CurrentUser.Firstname = FirstName.Text;
            App.CurrentUser.Lastname = LastName.Text;
            App.CurrentUser.Email = Email.Text;
            App.CurrentUser.Address = Address.Text;
            App.CurrentUser.Password = Password.Text;
            if (App.CurrentUser.Username == null || App.CurrentUser.Firstname == null || App.CurrentUser.Lastname == null || App.CurrentUser.Email == null || App.CurrentUser.Address == null || App.CurrentUser.Password == null)
            {
                await DisplayAlert("Alert", "Please finish filling out your information", "OK");
            }
            else
            {
                var newPage = new AppShell();
                App.Current.MainPage = newPage;
            }
            
        }
    }
}