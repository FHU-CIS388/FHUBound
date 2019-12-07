using FHUBound.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class VisitPage : ContentPage
    {

        VisitViewModel viewModel;

        public VisitPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new VisitViewModel();
        }

        private void ClearlevelButton_Clicked(object sender, EventArgs e)
        {
            App.CurrentUser.Points = 0;
            App.CurrentUser.TotalPoints = 0;
            App.CurrentUser.CalculateLevel();
            App.CurrentUser.Level = 0;
        }

        private void saveChangeButton_Clicked(object sender, EventArgs e)
        {
            App.CurrentUser.Username = changeUsernameEntry.Text;
            App.CurrentUser.Points = int.Parse(addPointsEntry.Text);
            App.CurrentUser.TotalPoints = int.Parse(addPointsEntry.Text);
            
            App.CurrentUser.CalculateLevel();
        }

       async private void navButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditProfilePage());
        }





        /*private void saveButton_Clicked(object sender, EventArgs e)
        {
            if (UserNameEntry.Text != null)
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
        }*/
    }
}
