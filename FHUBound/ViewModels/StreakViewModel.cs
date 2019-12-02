using FHUBound.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace FHUBound.ViewModels
{
    public class StreakViewModel : BaseViewModel
    {
        public User User { get; set; }

        public StreakViewModel()
        {
            User = App.CurrentUser;
        }

        public ICommand AddBucks
        {
            get
            {
                return new Command((c) =>
                {
                    int? intValue = (int)c;
                    User.CurrentPoints += (int)intValue;
                });
            }
        }
        public ICommand AddStreakPoints
        {
            get
            {
                return new Command(async (value) =>
                {
                    bool answer = await Application.Current.MainPage.DisplayAlert("Welcome Back!", "You have a 12 day streak." + Environment.NewLine + Environment.NewLine + "DShannon" + Environment.NewLine + Environment.NewLine + "Collect 1200 BoundBucks" + Environment.NewLine + "", "Collect Now!", "No thanks.");
                    if (answer == true)
                    {
                        int? intValue = value as int?;
                        AddBucks.Execute(1200);
                    }
                });
            }
        }
    }
}
