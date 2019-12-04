using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FHUBound.Models;
using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class HomePage : ContentPage
    {
        public ObservableCollection<Card> Cards { get; set; }

        public HomePage()
        {
            InitializeComponent();

            Cards = new ObservableCollection<Card>();

            Cards.Add(new Card() { HeaderTitle = "RUSH 2020", HeaderSubtitle = "Experience new spirital heights.", ImageUrl = "Rush.png", ButtonText = "REGISTER", Value = 25 });
            Cards.Add(new Card() { HeaderTitle = "So Much Fun", HeaderSubtitle = "FHU FUN", ImageUrl = "fhu_color_belltower.png", Value = 5 });
            Cards.Add(new Card() { HeaderTitle = "Find Your Fit", HeaderSubtitle = "MAJORS", ImageUrl= "istockpuzzle.jpg", ButtonText="Explore Majors", Value = 5 } );
            Cards.Add(new Card() { BodyTitle="TIP #45", BodyContent="Hang out with friends at Eno park. #hammockJokes", Value = 5 });

            CardsCollectionView.ItemsSource = Cards;

        }
    }
}
