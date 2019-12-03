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
    public partial class EditProfilePage : ContentPage
    {
        EditProfileViewModel viewModel;

        public EditProfilePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new EditProfileViewModel();
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
            if (PointsEntry.Text != null)
            {
               
                App.CurrentUser.Points = int.Parse(PointsEntry.Text);
                App.CurrentUser.TotalPoints += int.Parse(PointsEntry.Text);
                App.CurrentUser.CalculateLevel();
                PointsEntry.Text = "";
            }


        }

        private async void backButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }
    }
}