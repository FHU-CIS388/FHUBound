using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class VisitPage : ContentPage
    {
        public VisitPage()
        {
            InitializeComponent();
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
        }
    }
}
