using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FHUBound.Models;
using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ObservableCollection<Card> Cards { get; set; }

        public ProfilePage()
        {
            InitializeComponent();

            Cards = new ObservableCollection<Card>();
            Cards.Add(new Card() {
                BodyTitle = "Cameron Maguffee",
                ButtonText = "Edit Username"
            });
            Cards.Add(new Card()
            {
                HeaderTitle = "Badges Collected",
                BodyTitle = "😃  ❤️  😂  🎂  👨🏻‍🦳",
                BodyContent = "Newest badge: 👨🏻‍🦳 (David Shannon) Collect 500 points"
            });
            Cards.Add(new Card() {
                HeaderTitle = "Profile Pic",
                ImageUrl = "fhu_square.jpg",
                ButtonText = "Change Pic"
            });


            CardsCollectionView.ItemsSource = Cards;

        }
    }
}
