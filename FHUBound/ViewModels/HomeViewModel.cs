using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using FHUBound.Models;
using FHUBound.Services;
using System.ComponentModel;
using System.Windows.Input;
using System.Threading.Tasks;



namespace FHUBound.ViewModels
{
    class HomeViewModel : BaseViewModel, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
       
        public User User { get; set; }

        public ObservableCollection<Card> Cards { get; set; }

        public HomeViewModel()
        {
            User = App.CurrentUser;

            Cards = new ObservableCollection<Card>();
            Cards.Add(new Card() { HeaderTitle = "Find Your Fit", HeaderSubtitle = "MAJORS", ImageUrl = "istockpuzzle.jpg", ButtonText = "Explore Majors", Value = 5 });
            Cards.Add(new Card() { HeaderTitle = "Devos with David", HeaderSubtitle = "DEVO", ButtonText = "Watch More", Value = 10 });
            Cards.Add(new Card() { HeaderTitle = "RUSH 2020", HeaderSubtitle = "Experience new spirital heights.", ImageUrl = "Rush.png", ButtonText = "REGISTER", Value = 25 });
            Cards.Add(new Card() { BodyTitle = "TIP #45", BodyContent = "Hang out with friends at Eno park. #hammockJokes", Value = 5 });
            Cards.Add(new Card() { HeaderTitle = "So Much Fun", HeaderSubtitle = "FHU FUN", ImageUrl = "fhu_color_belltower.png", Value = 5 });




      

        }
        public ICommand AddPoints
        {
            get
            {
                return new Command((c) =>
                {
                    
                    var card = c as Card;
                    card.PointsNotCollected = false;

                    int? points = card.Value as int?;
                    User.TotalPoints += points.Value;
                }
                );
            }
        }
    }
}
