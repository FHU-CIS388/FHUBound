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
                    var numberString = c.ToString();
                    int numberInt = Int32.Parse(numberString);
                    Console.WriteLine("int!: "+ numberInt);
                    User.CurrentPoints += numberInt;
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
                    int addedPoints = User.Streak * 100;
                    bool answer = await Application.Current.MainPage.DisplayAlert("Welcome Back, "+ User.FirstName+"!", "You have a "+ User.Streak +" day streak." + Environment.NewLine + Environment.NewLine + "You've earned "+ addedPoints + " BoundBucks!" + Environment.NewLine + "", null, "COLLECT NOW!");
                    if (answer == false)
                    {
                        if (addedPoints != null)
                        {
                            AddBucks.Execute(addedPoints);
                        }
                        await Navigation.PopModalAsync();
                    }
                });
            }
        }
    }
}
