using FHUBound.Models;
using FHUBound.ViewModels;
using System;
using Xamarin.Essentials;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FHUBound.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginViewModel viewModel;
        User tempUser;
        public LoginPage()
        {
            InitializeComponent();
            tempUser = new User();
            viewModel = new LoginViewModel();
            BindingContext = viewModel;
        }

        private async Task Button_ClickedAsync(object sender, EventArgs e)
        {
            tempUser.Name = fullname.Text;
            tempUser.Password = password.Text;
            tempUser.MailingAddress = address.Text;
            tempUser.StreakLength = 1;
            tempUser.Birthday = birthday.Date;
            tempUser.Id = "5";
            App.CurrentUser = tempUser;
            Preferences.Set("current_user_id", (string)"5");
            await App.userDataStore.AddItemAsync(App.CurrentUser);
            Application.Current.MainPage = new AppShell();
        }
    }
}