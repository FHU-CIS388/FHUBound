﻿using FHUBound.Models;
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
                return new Command((value) =>
                {
                    int? intValue = value as int?;
                    if (intValue != null)
                    {
                        User.CurrentPoints += intValue.Value;
                    }
                });
            }
        }

        public ICommand RemoveBucks
        {
            get
            {
                return new Command((value) =>
                {
                    int? intValue = value as int?;
                    if (intValue != null)
                    {
                        User.CurrentPoints -= intValue.Value;
                    }
                });
            }
        }
    }
}