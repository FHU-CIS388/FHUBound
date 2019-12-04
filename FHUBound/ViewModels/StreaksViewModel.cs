using FHUBound.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace FHUBound.ViewModels
{
    public class StreaksViewModel : BaseViewModel
    {
        public User User { get; set; }

        public StreaksViewModel()
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
        public INavigation Navigation { get; set; }
        public ICommand AddStreakPoints
        {
            get
            {
                return new Command(async (value) =>
                {
                    bool answer = await Application.Current.MainPage.DisplayAlert("Welcome Back!", "DShannon," + Environment.NewLine + Environment.NewLine + "You have a 12 day streak." + Environment.NewLine + Environment.NewLine + "You've earned 1200 BoundBucks!" + Environment.NewLine + "", null, "COLLECT NOW!");
                    Console.WriteLine("BOOL IS: " + answer);
                    if (answer == false)
                    {
                        int? intValue = value as int?;
                        AddBucks.Execute(1200);
                        await Navigation.PopModalAsync();
                    }
                });
            }
        }
    }
}
