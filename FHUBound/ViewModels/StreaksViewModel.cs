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
                    bool answer = await Application.Current.MainPage.DisplayAlert("Welcome Back!", "DShannon," + Environment.NewLine + Environment.NewLine + "You have a 12 day streak." + Environment.NewLine + Environment.NewLine + "You've earned "+ value +" BoundBucks!" + Environment.NewLine + "", null, "COLLECT NOW!");
                    if (answer == false)
                    {
                        if (value != null)
                        {
                            AddBucks.Execute(value);
                        }
                        await Navigation.PopModalAsync();
                    }
                });
            }
        }
    }
}
