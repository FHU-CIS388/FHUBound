using FHUBound.Models;
using FHUBound.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace FHUBound.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public User User { get; set; }
        public ObservableCollection<Card> Cards { get; set; }
        public HomeViewModel()
        {
            User = App.CurrentUser;
            Cards = new ObservableCollection<Card>();
            Cards.Add(new Card() { HeaderTitle = "Find Your Fit", HeaderSubtitle = "MAJORS", ImageUrl = "istockpuzzle.jpg", ButtonText = "Explore Majors", Value = 2000 });
            Cards.Add(new Card() { HeaderTitle = "Devos with David", HeaderSubtitle = "DEVO", ButtonText = "Watch More", Value = 1000 });
            Cards.Add(new Card() { HeaderTitle = "RUSH 2020", HeaderSubtitle = "Experience new spirital heights.", ImageUrl = "Rush.png", ButtonText = "REGISTER", Value = 5000 });
            Cards.Add(new Card() { BodyTitle = "TIP #45", BodyContent = "Hang out with friends at Eno park. #hammockJokes", Value = 500 });
            Cards.Add(new Card() { HeaderTitle = "So Much Fun", HeaderSubtitle = "FHU FUN", ImageUrl = "fhu_color_belltower.png", Value = 500 });
        }
        public ICommand AddBucks
        {
            get
            {
                return new Command((c) =>
                {

                    var card = c as Card;
                    card.PointsButtonBool = false;

                    int? intValue = card.Value as int?;
                    if (intValue != null)
                    {
                        User.CurrentPoints += intValue.Value;
                    }
                });
            }
        }

        //TODO: Button won't click
        public Xamarin.Forms.INavigation Navigation { get; }
        public ICommand OpenCalendar
        {
            get
            {
                return new Command(async (c) =>
                {
                    System.Console.WriteLine("OpenCalendar has been CLICKED");
                    var streaks = new StreaksPage();
                    await Navigation.PushModalAsync(streaks);
                });
            }
        }
    }
}