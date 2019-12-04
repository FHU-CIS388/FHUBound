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

            Cards.Add(new Card()
            {
                HeaderTitle = "Baseball & Softball",
                HeaderSubtitle = "Our sports teams are awesome!",
                ImageUrl = "fhubaseball.jpg",
                ButtonText = "Learn More",
                Value = 30
            });
            Cards.Add(new Card() {
                HeaderTitle = "RUSH 2020",
                HeaderSubtitle = "Experience new spirital heights.",
                ImageUrl = "Rush.png",
                ButtonText = "REGISTER",
                Value = 25
            });
            Cards.Add(new Card()
            {
                HeaderTitle = "Housing",
                HeaderSubtitle = "Where to Stay",
                ImageUrl = "Dorms_1.JPG",
                ButtonText = "Explore Dorms",
                Value = 20
            });
            Cards.Add(new Card() {
                HeaderTitle = "So Much Fun",
                HeaderSubtitle = "FHU FUN",
                ImageUrl = "fhu_color_belltower.png",
                Value = 10
            });
            Cards.Add(new Card() {
                HeaderTitle = "Find Your Fit",
                HeaderSubtitle = "MAJORS",
                ImageUrl= "mat.jpg",
                ButtonText="Explore Majors",
                Value = 5
            });
            Cards.Add(new Card() {
                BodyTitle="TIP #10",
                BodyContent="Reserve a room at the library to shield yourself from distractions. #FHULibrary",
                Value = 5
            });

            CardsCollectionView.ItemsSource = Cards;

        }
    }
}
