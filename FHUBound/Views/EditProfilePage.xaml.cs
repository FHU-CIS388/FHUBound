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
    public partial class EditProfilePage : ContentPage
    {
        public EditProfilePage()
        {
            InitializeComponent();
        }

        private void saveButton_Clicked(object sender, EventArgs e)
        {
            if(UserNameEntry.Text != null)
            {
                App.CurrentUser.Username = UserNameEntry.Text;
                UserNameEntry.Text = "";
            }
            if (FirstNameEntry.Text != null)
            {
                App.CurrentUser.FirstName = FirstNameEntry.Text;
                FirstNameEntry.Text = "";
            }
            if (LastNameEntry.Text != null)
            {
                App.CurrentUser.LastName = LastNameEntry.Text;
                LastNameEntry.Text = "";
            }

            App.CurrentUser.LastName = LastNameEntry.Text;
        }

        private async void backButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }
    }
}